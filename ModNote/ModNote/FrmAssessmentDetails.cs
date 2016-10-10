using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmAssessmentDetails : Form
    {
        /// <summary>
        /// Create Variables and Properties
        /// </summary>
        private IAssessment assessment;
        public IAssessment Assessment
        {
            get
            {
                return assessment;
            }

            set
            {
                assessment = value;
            }
        }
        private FrmAssessmentsNotes assessmentNotesFrm;
        private bool notesShown;
        /// <summary>
        /// Initiliaze form and create notes form
        /// </summary>
        /// <param name="assessment"></param>
        public FrmAssessmentDetails(IAssessment assessment)
        {
            InitializeComponent();
            this.Assessment = assessment;
            assessmentNotesFrm = new FrmAssessmentsNotes(this);

        }


        /// <summary>
        /// On form load load assessment information into textboxes and add event to progtrakbar
        /// </summary>
        private void FrmAssessmentDetails_Load(object sender, EventArgs e)
        {
            PrgTrkBrAssignmentPrcntCmplt.trackBarValueChanged +=
                new EventHandler(progressTrackBar1_TrackBarValueChanged);
            PrgTrkBrAssignmentPrcntCmplt.Enabled = true;
            notesShown = false;
            if (Assessment != null)
                TxtbxModule.ReadOnly = true;
            if (Assessment is IAssignment) //If assessment is an assignment then make assignment panel visible and load data into fields
            {
                IAssignment assignment = Assessment as IAssignment;
                PnlAssignment.Visible = true;
                PnlTest.Visible = false;
                LblAssessmentType.Text = "Assignment";
                TxtbxModule.Text = assignment.Module;
                TxtbxText.Text = assignment.Text;
                TxtbxTitle.Text = assignment.Title;
                ChkbxAssignmentDateReached.Checked = assignment.DueDateReached;
                DtePkrAssignmentDueDate.Value = assignment.Date;
                PrgTrkBrAssignmentPrcntCmplt.TrackBarValue = assignment.PercentageComplete;
            } else if (Assessment is ITest)
            {
                ITest test = Assessment as ITest; //If assessment is a test then make test panel visible and load data into fields
                PnlTest.Visible = true;
                PnlAssignment.Visible = false;
                LblAssessmentType.Text = "Test";
                TxtbxModule.Text = test.Module;
                TxtbxText.Text = test.Text;
                TxtbxTitle.Text = test.Title;
                DtePkrTestDate.Value = test.Date;
                TxtbxTestRoom.Text = test.Room;
                TxtbxTestSeat.Text = test.Seat;
                NUDTestDuration.Value = (decimal)test.Duration;
            }
        }

        /// <summary>
        /// Changing the value of the progtrakbar will update the label showing the percentage
        /// </summary>
        void progressTrackBar1_TrackBarValueChanged(object sender, EventArgs e)
        {
            PrgTrkBr ptb = (PrgTrkBr)sender;
            LblAssignmentPrgrss.Text = ptb.TrackBarValue.ToString()+"%";
        }

        /// <summary>
        /// When the forms location is changed update the location of notes form
        /// </summary>
        private void FrmAssessmentDetails_LocationChanged(object sender, EventArgs e)
        {
            int width= TxtbxText.Width; //Get the width of the form
            int borderWidth = ((this.Width - width) / 2); //Get the width of the borders, and use them to adjust the location
            assessmentNotesFrm.Location = new Point(this.Location.X + width + borderWidth, this.Location.Y + ((this.Height - (int)(borderWidth*1.5)) - assessmentNotesFrm.Height));
        }

       
        /// <summary>
        /// Clicking notes button shows/hides notes form without stealing focus
        /// </summary>
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            if (!notesShown)
                assessmentNotesFrm.Show(this); //Show note form and set its owner to this form
            else
                assessmentNotesFrm.Hide();
            notesShown = !notesShown;
        }
        /// <summary>
        /// On this form becoming active, bring the notes form to the front alongside, if it is visible.
        /// </summary>
        private void FrmAssessmentDetails_Activated(object sender, EventArgs e)
        {
            if (notesShown)
            {
                assessmentNotesFrm.Visible = false;
                assessmentNotesFrm.Show(this);
            }
        }

        /// <summary>
        /// On clicking Save button check if necessary fields are filled and then return dialogresult ok
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtbxModule.Text) && !string.IsNullOrWhiteSpace(TxtbxTitle.Text))
            {
                
                if (Assessment is IAssignment)
                {
                    IAssignment assignment = new Assignment(TxtbxTitle.Text, TxtbxModule.Text, TxtbxText.Text,
                        DtePkrAssignmentDueDate.Value, ChkbxAssignmentDateReached.Checked,
                        PrgTrkBrAssignmentPrcntCmplt.TrackBarValue, Assessment.Notes); //Creates a new assignment with the information
                    Assessment = assignment;
                    this.DialogResult = DialogResult.OK; //Close form by returning dialogresult ok
                }
                else if (Assessment is ITest)
                {
                    ITest test = new Test(TxtbxTitle.Text, TxtbxModule.Text, TxtbxText.Text, DtePkrTestDate.Value, TxtbxTestSeat.Text, TxtbxTestRoom.Text, (double)NUDTestDuration.Value, Assessment.Notes);
                    Assessment = test;
                    this.DialogResult = DialogResult.OK;
                }
            }    
            else
            {
                if (string.IsNullOrWhiteSpace(TxtbxModule.Text)) //Tess user to input appropriate fields
                {
                    MessageBox.Show("Please enter a module Code");
                } else
                {
                    MessageBox.Show("Please enter a module Title");
                }
            }        
        }
        /// <summary>
        /// Procedure to check if date on the assessment is earlier or equal to the current date
        /// and check the date reached checkbox if it is
        /// </summary>
        private void CheckDate()
        {
            if (DtePkrAssignmentDueDate.Value.Date.CompareTo(DateTime.Now.Date) <= 0)
                ChkbxAssignmentDateReached.Checked = true;
            else
                ChkbxAssignmentDateReached.Checked = false;
        }
        /// <summary>
        /// On changing the Assignments datepicker value calls the procedure CheckDate()
        /// </summary>
        private void DtePkrAssignmentDueDate_ValueChanged(object sender, EventArgs e)
        {
            CheckDate();
        }
    }
}
