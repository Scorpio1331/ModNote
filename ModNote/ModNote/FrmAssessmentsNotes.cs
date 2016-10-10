using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace ModNote
{
    public partial class FrmAssessmentsNotes : Form
    {
        /// <summary>
        /// Override forms showWithoutActivation value so the form doesnt steal focus
        /// </summary>
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        /// <summary>
        /// Create references and properties to reference parent forms
        /// </summary>
        private FrmAssessmentDetails assessmentFrm;
        public FrmAssessmentDetails AssessmentFrm
        {
            get
            {
                return assessmentFrm;
            }

            set
            {
                assessmentFrm = value;
            }
        }
        private FrmModuleDetails moduleFrm;        
        public FrmModuleDetails ModuleFrm
        {
            get
            {
                return moduleFrm;
            }

            set
            {
                moduleFrm = value;
            }
        }

        /// <summary>
        /// Initialize Form and variables and set reference to owning form
        /// </summary>
        /// <param name="assessmentFrm">Reference to parent assessment form</param>
        public FrmAssessmentsNotes(FrmAssessmentDetails assessmentFrm)
        {
            InitializeComponent();
            AssessmentFrm = assessmentFrm; //Set reference to owning form and make other form reference null
            ModuleFrm = null;
            FlwLytPnlAssessmentsGrid.Visible = false; //Set note grid visible because owning form is and assessment form
            FlwLytPnlNotesGrid.Visible = true;
            foreach (INote note in AssessmentFrm.Assessment.Notes) //Loop through assessments notes and add note buttons
            {
                AddButtons(note.Title, true);
            }
        }
        /// <summary>
        /// Initialize Form and variables and set reference to owning form
        /// </summary>
        /// <param name="moduleFrm">Reference to parent module form</param>
        public FrmAssessmentsNotes(FrmModuleDetails moduleFrm)
        {
            InitializeComponent();
            ModuleFrm = moduleFrm;//Set reference to owning form and make other form reference nul
            AssessmentFrm = null;
            FlwLytPnlAssessmentsGrid.Visible = true;//Set assessment grid visible because owning form is and module form
            FlwLytPnlNotesGrid.Visible = false;
            foreach (IAssessment assessment in ModuleFrm.Module.Assessments) ////Loop through modules assessments and add assessment buttons
            {
                AddButtons(assessment.Title, false);
            }
            foreach (INote note in ModuleFrm.Module.Notes) //Loop through modules notes and add note buttons
            {
                AddButtons(note.Title, true);
            }
        }

        /// <summary>
        /// Procedure to add a button to flowlayoutpanels 
        /// </summary>
        /// <param name="text">Text for the button</param>
        /// <param name="note">Whether the button is for a note or not</param>
        public void AddButtons(string text, bool note)
        {
            Debug.WriteLine(" * *****-AddButtons(string,bool) Called- ******");
            Button newBtn = new Button();
            Debug.WriteLine("New buttons name/text: "+text);
            newBtn.Name = text;
            newBtn.Text = text;
            newBtn.AutoSize = true;
            newBtn.ContextMenuStrip = CntxtMnuStrpItems; //Add contextmenustrip to each button
            if (note)
            {
                Debug.WriteLine("Branch 1: New button is for a Note");
                newBtn.Click += NoteClicked;//If button is for a note add click event pointer to note clicked procedure 
                FlwLytPnlNotesGrid.Controls.Add(newBtn); //add button to note grid
            }
            else
            {
                Debug.WriteLine("Branch 2: New button is for an Assessment");
                newBtn.Click += AssessmentClicked;//If button is for an assessment add click event pointer to assessment clicked procedure
                FlwLytPnlAssessmentsGrid.Controls.Add(newBtn);//add button to assessment grid
            }
            Debug.WriteLine(" ******-AddButtons function ending-******\n");
        }           

        /// <summary>
        /// If note button is clicked find corrosponding note and open in dialog form
        /// </summary>
        private void NoteClicked(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            INote note;
            if (ModuleFrm != null) //If owning form is module frm find corrosponding note in module note list
            {
                note = ModuleFrm.Module.Notes.Find(item => item.Title == clickedBtn.Name);
            } else //else find note in assessment note list
            {                
                 note = AssessmentFrm.Assessment.Notes.Find(item => item.Title == clickedBtn.Name);                
            }
            FrmNoteDetails noteDetailsForm = new FrmNoteDetails(note); //Create form and initialize it with note to be viewed/edited
            noteDetailsForm.ShowDialog();
            if (noteDetailsForm.DialogResult == DialogResult.Cancel)
                return;
            clickedBtn = editButton(clickedBtn, note.Title); //call function to edit button
        }
        /// <summary>
        /// If assessment button is clicked find corrosponding assessment and open in dialog form
        /// </summary>
        private void AssessmentClicked(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            IAssessment assessment = ModuleFrm.Module.Assessments.Find(item => item.Title == clickedBtn.Name); //Find corrosponding assessment in module assessment list
            FrmAssessmentDetails assessmentDetailsFrm = new FrmAssessmentDetails(assessment); //Create form and initialize it with assessment to be viewed/edited
            assessmentDetailsFrm.ShowDialog();
            if (assessmentDetailsFrm.DialogResult == DialogResult.Cancel)
                return;
            ModuleFrm.Module.Assessments[ModuleFrm.Module.Assessments.IndexOf(assessment)] = assessmentDetailsFrm.Assessment; //Get assessment and save it
            assessment = assessmentDetailsFrm.Assessment;
            clickedBtn = editButton(clickedBtn, assessment.Title); //call function to edit button
        }
        /// <summary>
        /// Function to change a buttons name and text
        /// </summary>
        /// <param name="clickedBtn">Button to be edited</param>
        /// <param name="title">title to change the name and text to</param>
        /// <returns>button with changed name and text</returns>
        private Button editButton(Button clickedBtn,string title)
        {
            clickedBtn.Name = title;
            clickedBtn.Text = title;
            return clickedBtn;
        }
        /// <summary>
        /// On clicking Add Item button create a new assessment or note depending on what panel is visible
        /// </summary>
        private void BtnAddNoteAssessment_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("\n******- BtnAddNoteAssessment_Click(object,EventArgs) Called -******");
       
            if (ModuleFrm != null) //If parent form is module form
            {
                Debug.WriteLine("Branch 1: Module form is not null, Determining whether to add note or assessment");
                if (FlwLytPnlAssessmentsGrid.Visible == false)
                {
                    Debug.WriteLine("Branch 1: Assessment panel is not visible, so therefore add Note");
                    FrmNoteDetails noteDetailsForm = new FrmNoteDetails(); //Create new form to create a new note
                    do //loop to validate note name
                    {
                        Debug.WriteLine("Opening Note Details form");
                        noteDetailsForm.ShowDialog();
                        if (noteDetailsForm.DialogResult == DialogResult.Cancel) { 
                            Debug.WriteLine("Branch 1: User clicked cancel button, exiting procedure");
                            Debug.WriteLine(" ******-BtnAddNoteAssessment_Click function ending-******\n");
                            return;
                        }
                        if (ModuleFrm.Module.Notes.FindAll(item => item.Title == noteDetailsForm.Note.Title).Count == 0) { //if module note list contains a note with same name tell user to rename 
                            Debug.WriteLine("Branch 1: User clicked save and the new note has a unique title");
                            break;
                        }
                        else
                        {
                            Debug.WriteLine("Branch 2: User clicked save but new notes title conflicts with another note");
                            MessageBox.Show("An note with that name already exists, please change the name.", "Error", MessageBoxButtons.OK);
                            noteDetailsForm = new FrmNoteDetails(noteDetailsForm.Note); //Reinitialize form with new note
                        }
                    } while (true);
                    Debug.WriteLine("Adding new note to module and calling function to create a button for it");    
                    ModuleFrm.Module.Notes.Add(noteDetailsForm.Note); //Add new note to module note list and then create a new button for it
                    AddButtons(noteDetailsForm.Note.Title, true);                    
                } else
                {
                    Debug.WriteLine("Branch 2: Assessment panel is visible, so therefore add Assessment");
                    FrmAssessmentType assessmentType = new FrmAssessmentType(); //Create new forms to create a new assessment
                    Debug.WriteLine("Opening Assessment Type form");
                    assessmentType.ShowDialog();
                    FrmAssessmentDetails assessmentDetailsForm;
                    if (assessmentType.DialogResult == DialogResult.OK) //If type form returns OK then create a new assignment
                    {
                        Debug.WriteLine("Branch 1: User clicked Assignment button, creating Assessment details form with a new Assignment");
                        assessmentDetailsForm = new FrmAssessmentDetails(new Assignment("", ModuleFrm.Module.Code, "", DateTime.Now.Date, false, 0));
                    }
                    else if (assessmentType.DialogResult == DialogResult.Yes)//If type form returns Yes then create a new test
                    {
                        Debug.WriteLine("Branch 2: User clicked Test button, creating Assessment details form with a new Test");
                        assessmentDetailsForm = new FrmAssessmentDetails(new Test("", ModuleFrm.Module.Code, "", DateTime.Now.Date, "", "", 60));
                    }
                    else
                    {
                        Debug.WriteLine("Branch 3: User clicked exit button, exiting procedure");
                        Debug.WriteLine(" ******-BtnAddNoteAssessment_Click function ending-******\n");
                        return;
                    }
                    do //loop to validate assessment name
                    {
                        Debug.WriteLine("Opening Assessment Details form");
                        assessmentDetailsForm.ShowDialog();
                        if (assessmentDetailsForm.DialogResult == DialogResult.Cancel)
                        {
                            Debug.WriteLine("Branch 1: User clicked cancel button, exiting procedure");
                            Debug.WriteLine(" ******-BtnAddNoteAssessment_Click function ending-******\n");
                            return;
                        }
                        if (ModuleFrm.Module.Assessments.FindAll(item=>item.Title == assessmentDetailsForm.Assessment.Title).Count == 0) {//if module assessment list contains an assessment with same name tell user to rename
                            Debug.WriteLine("Branch 1: User clicked save and the new assessment has a unique title");
                            break;
                        }
                        else
                        {
                            Debug.WriteLine("Branch 2: User clicked save but new assessment title conflicts with another assessments");
                            MessageBox.Show("An assessment with that name already exists, please change the name.", "Error", MessageBoxButtons.OK);
                            assessmentDetailsForm = new FrmAssessmentDetails(assessmentDetailsForm.Assessment);
                        }                            
                    } while (true);
                    Debug.WriteLine("Adding new assessment to module and calling function to create a button for it");
                    ModuleFrm.Module.addAssessment(assessmentDetailsForm.Assessment); //Add new assessment to module assessment list and create new button
                    AddButtons(assessmentDetailsForm.Assessment.Title, false);
                }
            } else //else if parent form is assessment form
            {
                Debug.WriteLine("Branch 2: Module form is null, creating a note for an Assessment");
                FrmNoteDetails noteDetailsForm = new FrmNoteDetails();
                do //loop to validate note name
                {
                    Debug.WriteLine("Opening Note Details form");
                    noteDetailsForm.ShowDialog();
                    if (noteDetailsForm.DialogResult == DialogResult.Cancel)
                    {
                        Debug.WriteLine("Branch 1: User clicked cancel button, exiting procedure");
                        Debug.WriteLine(" ******-BtnAddNoteAssessment_Click function ending-******\n");
                        return;
                    }
                    if (AssessmentFrm.Assessment.Notes.FindAll(item => item.Title == noteDetailsForm.Note.Title).Count == 0) {//if module note list contains a note with same name tell user to rename
                        Debug.WriteLine("Branch 1: User clicked save and the new note has a unique title");
                        break;
                    }
                    else
                    {
                        Debug.WriteLine("Branch 1: User clicked save but new notes title conflicts with another notes");
                        MessageBox.Show("An note with that name already exists, please change the name.", "Error", MessageBoxButtons.OK);
                        noteDetailsForm = new FrmNoteDetails(noteDetailsForm.Note);
                    }
                } while (true);
                Debug.WriteLine("Adding new note to assessment and calling function to create a button for it");
                AssessmentFrm.Assessment.Notes.Add(noteDetailsForm.Note); //Add new note to assessment note list and create new button
                AddButtons(noteDetailsForm.Note.Title, true);
            }
            
                Debug.WriteLine(" ******-BtnAddNoteAssessment_Click function ending-******\n");
            
        }
        /// <summary>
        /// On clicking Delete Note button get buttons contextmenustrips owner and removes the button from flowlayoutpanel and remove the
        /// note/assessment from the list
        /// </summary>
        private void TlStrpMnuItmDeleteNote_Click(object sender, EventArgs e)
        {
            ToolStripItem deleteBtn = sender as ToolStripItem;
            if (deleteBtn != null)
            {
                ContextMenuStrip owner = deleteBtn.Owner as ContextMenuStrip; //Get the contextmenustrip that owns this toolstripitem
                if (owner != null)
                {
                    Button itemBtn = owner.SourceControl as Button;
                    
                    if (itemBtn.Parent == FlwLytPnlAssessmentsGrid) //If button is assessment button remove button from panel and module assessments
                    {

                        IAssessment assessment = ModuleFrm.Module.Assessments.Find(item => item.Title == itemBtn.Name);
                        ModuleFrm.Module.Assessments.Remove(assessment);
                        FlwLytPnlAssessmentsGrid.Controls.Remove(itemBtn);

                    } else if (itemBtn.Parent == FlwLytPnlNotesGrid && ModuleFrm != null)//If button is note button and parent form is module form remove button from panel and module notes
                    {
                        INote note = ModuleFrm.Module.Notes.Find(item => item.Title == itemBtn.Name);
                        ModuleFrm.Module.Notes.Remove(note);
                        FlwLytPnlNotesGrid.Controls.Remove(itemBtn);
                    }
                    else //If button is note button and owner form is assessment form remove button from panel and assessments notes
                    {
                        INote note = AssessmentFrm.Assessment.Notes.Find(item => item.Title == itemBtn.Name);
                        AssessmentFrm.Assessment.Notes.Remove(note);
                        FlwLytPnlNotesGrid.Controls.Remove(itemBtn);
                    }
                       
                    
                }
            }
        }
        /// <summary>
        /// Procedure to change the visibility on the panels
        /// </summary>
        /// <param name="showNotes">Whether to show notes</param>
        public void ShowNotes(bool showNotes)
        {
            if (showNotes) 
            {
                FlwLytPnlNotesGrid.Visible = true;
                FlwLytPnlAssessmentsGrid.Visible = false;
            }                
            else
            {
                FlwLytPnlAssessmentsGrid.Visible = true;
                FlwLytPnlNotesGrid.Visible = false;
            }                
        }

    }
}
