using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmModuleDetails : Form
    {
        /// <summary>
        /// Create variables, properties and reference to store module values and allow access outside the form
        /// </summary>
        private bool importFile = false;
        private IModule module;
        public IModule Module
        {
            get
            {
                return module;
            }

            set
            {
                module = value;
            }
        }
        private bool assessmentsLastButtonClicked;
        private FrmMain mainForm;
        private FrmAssessmentsNotes assessmentNotes;
        private bool assessmentsNotesShown;
        private Queue<string> assessments = new Queue<string>();

        /// <summary>
        /// Initialize Form and variables and set reference to owning form
        /// </summary>
        /// <param name="importFile">Whether to import a module from a file</param>
        /// <param name="mainForm">Reference to parent form</param>
        public FrmModuleDetails(bool importFile, FrmMain mainForm)
        {
            InitializeComponent();
            this.importFile = importFile;
            this.mainForm = mainForm;
            Module = new Module("", "", "", new List<string>());
            assessmentNotes = new FrmAssessmentsNotes(this);
        }
        /// <summary>
        /// Initialize form and variables
        /// </summary>
        /// <param name="module"></param>
        public FrmModuleDetails(IModule module)
        {
            InitializeComponent();
            this.Module = module;
            assessmentNotes = new FrmAssessmentsNotes(this);
        }
        /// <summary>
        /// On load if importing a file opens the openfiledialog and reads in a textfile, then fills the forms fields with the data
        /// </summary>
        private void FrmModuleDetails_Load(object sender, EventArgs e)
        {
            if (importFile)
            {
                string fileName;
                try
                {
                    OpnFlDlgModuleSelector.ShowDialog();
                    fileName = OpnFlDlgModuleSelector.FileName;
                    if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(fileName)) //If file exists continue
                    {
                        string code = "";
                        string title = "";
                        string synopsis = "";
                        List<string> learningObjectives = new List<string>();
                        using (StreamReader fileReader = new StreamReader(fileName)) //Open file in streamreader
                        {
                            string temp = "";

                            do
                            {
                                if (temp.Contains("\t"))//remove string literals and trim whitespace at end
                                    temp = temp.Replace("\t", "");
                                if (temp.Contains("\n"))
                                    temp = temp.Replace("\n", "");
                                switch (temp.TrimEnd(' ')) //Use switch to determine what data is what
                                {
                                    case "CODE":
                                        code = fileReader.ReadLine();
                                        break;
                                    case "TITLE":
                                        title = fileReader.ReadLine();
                                        break;
                                    case "SYNOPSIS":
                                        synopsis = fileReader.ReadLine();
                                        do //Loop until end of synopsis
                                        {
                                            temp = fileReader.ReadLine();
                                            if (!temp.Contains("LO"))
                                            {
                                                synopsis += temp;
                                            }
                                            else break;

                                        } while (true);
                                        continue;//continue to next loop cycle without reading a new line
                                    case "LO":
                                        learningObjectives.Add(fileReader.ReadLine());
                                        do
                                        {
                                            temp = fileReader.ReadLine();
                                            if (temp.Contains("LO"))
                                            {
                                                learningObjectives.Add(temp);//loop until end of Learning objectives and add them to list
                                            }
                                            else break;

                                        } while (true);
                                        continue;
                                    case "ASSIGNMENT":
                                        temp = fileReader.ReadLine();
                                        assessments.Enqueue(temp); //Add assessments to queue then loop until end of stream
                                        do
                                        {
                                            temp = fileReader.ReadLine();
                                            if (temp == null)
                                                break;
                                            assessments.Enqueue(temp);
                                        } while (!fileReader.EndOfStream);
                                        if (assessments.Count > 0) //If assessments are in the queue, edit button text and make button visible
                                        {
                                            BtnAssessmentQueue.Text = "Assessment Queue: " + assessments.Count;
                                            BtnAssessmentQueue.Visible = true;
                                        }
                                        break;
                                    default:
                                        break;

                                }
                                temp = fileReader.ReadLine(); //Read next line of file into temp

                            } while (!fileReader.EndOfStream);


                        }
                        TxtbxModuleCode.Text = code;
                        TxtbxTitle.Text = title;
                        TxtbxSynopsis.Text = synopsis;
                        AddLearningObjectives(learningObjectives); //Fill fields in with data

                        Module = new Module(code, title, synopsis, learningObjectives, fileName, null, null); //create new module with data
                        if (mainForm.Modules.Count > 0 && mainForm.Modules.Contains(Module)) //If module is already loaded tell user
                        {
                            throw new Exception("Module already loaded");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                TxtbxModuleCode.Text = Module.Code;
                TxtbxTitle.Text = Module.Title;
                TxtbxSynopsis.Text = Module.Synopsis;
                AddLearningObjectives(Module.LearningObjectives);//if not importing module from file fill in fields current module data
                
            }
        }

        /// <summary>
        /// Procedure to add learning objectives to listview
        /// </summary>
        /// <param name="learningObjectives">List of learning objectives to add</param>
        private void AddLearningObjectives(List<string>learningObjectives)
        {
            foreach (string learningObjective in learningObjectives) //loop through learning objectives and add each to listview
            {
                LstVwLearningObj.Items.Add(new ListViewItem(learningObjective));
            }
        }

        /// <summary>
        /// Function to create an assessment based on a string, and open a form to edit the details.
        /// then return the assessment
        /// </summary>
        /// <param name="text">String to create an assessment</param>
        /// <param name="moduleCode">Code of the module assessment belongs too</param>
        /// <returns>Returns assessment</returns>
        private IAssessment CreateAssessment(string text, string moduleCode)
        {
            FrmAssessmentDetails createAssessmentForm;
            if (text.Contains("Test")) //If the string contains the word Test then create a Test
            {
                DateTime date;
                DateTime.TryParse(new Regex(@"\d{2}\/\d{2}\/\d*").Match(text).Value, out date);
                createAssessmentForm = new FrmAssessmentDetails(new Test("", moduleCode, "", date, "", "", 60));
                do//Loop until user gives the assessment a name that does not conflict with other modules
                {
                    createAssessmentForm.ShowDialog();
                    if (createAssessmentForm.DialogResult == DialogResult.Cancel)
                        return null;
                    if (Module.Assessments.FindAll(item => item.Title == createAssessmentForm.Assessment.Title).Count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("An assessment with that name already exists, please change the name.", "Error", MessageBoxButtons.OK);
                        createAssessmentForm = new FrmAssessmentDetails(createAssessmentForm.Assessment);
                    }
                } while (true);
                return createAssessmentForm.Assessment;
            }
            else if (text.Contains("Assignment")) //If the string contains the word Assignment then create an Assignment
            {
                DateTime date;
                DateTime.TryParse(new Regex(@"\d{2}\/\d{2}\/\d*").Match(text).Value, out date);
                Boolean dateReached = (date.Equals(DateTime.Now));
                createAssessmentForm = new FrmAssessmentDetails(new Assignment("", moduleCode, "", date, dateReached, 0));
                do//Loop until user gives the assessment a name that does not conflict with other modules
                {
                    createAssessmentForm.ShowDialog();
                    if (createAssessmentForm.DialogResult == DialogResult.Cancel)
                        return null;
                    if (Module.Assessments.FindAll(item => item.Title == createAssessmentForm.Assessment.Title).Count == 0)
                        break;
                    else
                    {
                        MessageBox.Show("An assessment with that name already exists, please change the name.", "Error", MessageBoxButtons.OK);
                        createAssessmentForm = new FrmAssessmentDetails(createAssessmentForm.Assessment);
                    }
                } while (true);
                return createAssessmentForm.Assessment;
            }
            return null;
        }

        /// <summary>
        /// On clicking the assessments button if the the assessmentsNotes form is not shown, it will be shown,
        /// or if the notes button was last pressed it will show the assessments buttons
        /// </summary>
        private void BtnAssessments_Click(object sender, EventArgs e)
        {
            if (!assessmentsNotesShown)
            {
                assessmentNotes.Visible = false;
                assessmentNotes.Show(this);
                assessmentNotes.ShowNotes(false);
            }
            else
            {
                if (assessmentsLastButtonClicked == true)
                    assessmentNotes.Hide();
                else
                    assessmentNotes.ShowNotes(false);
            }
            assessmentsLastButtonClicked = true;
            assessmentsNotesShown = !assessmentsNotesShown;
        }
        /// <summary>
        /// On clicking the notes button if the the assessmentsNotes form is not shown, it will be shown,
        /// or if the assessments button was last pressed it will show the assessments buttons
        /// </summary>
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            if (!assessmentsNotesShown)
            {
                assessmentNotes.Visible = false;
                assessmentNotes.Show(this);
                assessmentNotes.ShowNotes(true);
            }           
            else
            {
                if (assessmentsLastButtonClicked == false)
                    assessmentNotes.Hide();
                else
                    assessmentNotes.ShowNotes(true);
            }
            assessmentsLastButtonClicked = false;
            assessmentsNotesShown = !assessmentsNotesShown;
        }

        /// <summary>
        /// When the forms location is changed update the location of notes form
        /// </summary>
        private void FrmModuleDetails_LocationChanged(object sender, EventArgs e)
        {
            int width = this.DesktopBounds.Width;
            int borderWidth = ((this.Width - width) / 2);
            assessmentNotes.Location = new Point(this.Location.X + width + borderWidth, this.Location.Y + ((this.Height - (int)(borderWidth)) - assessmentNotes.Height));
        }
        /// <summary>
        /// On this form becoming active, bring the notes form to the front alongside, if it is visible.
        /// </summary>
        private void FrmModuleDetails_Activated(object sender, EventArgs e)
        {
            if (assessmentsNotesShown)
            {
                assessmentNotes.Hide();
                assessmentNotes.Show();
            }
        }

        /// <summary>
        /// On clicking Save button check if necessary fields are filled and then return dialogresult ok
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtbxModuleCode.Text) && !string.IsNullOrWhiteSpace(TxtbxTitle.Text))
            {
                Module.Code = TxtbxModuleCode.Text;
                Module.Synopsis = TxtbxSynopsis.Text;
                Module.Title = TxtbxTitle.Text;
                if (assessments != null && assessments.Count > 0) //If there are still assessments waiting in the queue then ask user if they want to abandon them
                    if (MessageBox.Show("You still have " + assessments.Count + " assessments waiting to be added, are you sure you wish to continue with saving? (they will be deleted if not added)", "Assessments in Queue", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(TxtbxModuleCode.Text))
                {
                    MessageBox.Show("Please enter A module Code");
                }
                else
                {
                    MessageBox.Show("Please enter a module title");
                }
            }
        }

        /// <summary>
        /// On clicking the assessment queue button Create assessment with the assessment data and dequeue it, then update the button
        /// </summary>
        private void BtnAssessmentQueue_Click(object sender, EventArgs e)
        {
            if (assessments != null && assessments.Count > 0)
            {
                IAssessment newAssessment = CreateAssessment(assessments.Dequeue(), Module.Code);
                if (newAssessment != null)
                {
                    Module.addAssessment(newAssessment);
                    assessmentNotes.AddButtons(newAssessment.Title, false);
                    if (assessments.Count > 0)
                        BtnAssessmentQueue.Text = "Assessment Queue: " + assessments.Count;
                    else
                    {
                        assessments.Clear();
                        assessments = null;
                        BtnAssessmentQueue.Visible = false;
                    }
                }
                
            }
        }
    }
}
