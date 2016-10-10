namespace ModNote
{
    partial class FrmAssessmentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblModule = new System.Windows.Forms.Label();
            this.TxtbxModule = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtbxTitle = new System.Windows.Forms.TextBox();
            this.PnlAssignment = new System.Windows.Forms.Panel();
            this.PrgTrkBrAssignmentPrcntCmplt = new ModNote.PrgTrkBr();
            this.LblAssignmentPrgrss = new System.Windows.Forms.Label();
            this.LblAssignmentPrcntCmplt = new System.Windows.Forms.Label();
            this.ChkbxAssignmentDateReached = new System.Windows.Forms.CheckBox();
            this.DtePkrAssignmentDueDate = new System.Windows.Forms.DateTimePicker();
            this.LblAssignmentDueDate = new System.Windows.Forms.Label();
            this.PnlTest = new System.Windows.Forms.Panel();
            this.DtePkrTestDate = new System.Windows.Forms.DateTimePicker();
            this.TxtbxTestSeat = new System.Windows.Forms.TextBox();
            this.LblTestSeat = new System.Windows.Forms.Label();
            this.TxtbxTestRoom = new System.Windows.Forms.TextBox();
            this.LblTestRoom = new System.Windows.Forms.Label();
            this.LblTestMinutes = new System.Windows.Forms.Label();
            this.LblTestDuration = new System.Windows.Forms.Label();
            this.NUDTestDuration = new System.Windows.Forms.NumericUpDown();
            this.LblTestDate = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.TxtbxText = new System.Windows.Forms.TextBox();
            this.LblAssessmentType = new System.Windows.Forms.Label();
            this.BtnNotes = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnlAssignment.SuspendLayout();
            this.PnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTestDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // LblModule
            // 
            this.LblModule.AutoSize = true;
            this.LblModule.Location = new System.Drawing.Point(11, 34);
            this.LblModule.Name = "LblModule";
            this.LblModule.Size = new System.Drawing.Size(45, 13);
            this.LblModule.TabIndex = 0;
            this.LblModule.Text = "Module:";
            // 
            // TxtbxModule
            // 
            this.TxtbxModule.Location = new System.Drawing.Point(65, 31);
            this.TxtbxModule.Name = "TxtbxModule";
            this.TxtbxModule.Size = new System.Drawing.Size(108, 20);
            this.TxtbxModule.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(210, 34);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Title:";
            // 
            // TxtbxTitle
            // 
            this.TxtbxTitle.Location = new System.Drawing.Point(265, 28);
            this.TxtbxTitle.Name = "TxtbxTitle";
            this.TxtbxTitle.Size = new System.Drawing.Size(108, 20);
            this.TxtbxTitle.TabIndex = 3;
            // 
            // PnlAssignment
            // 
            this.PnlAssignment.Controls.Add(this.PrgTrkBrAssignmentPrcntCmplt);
            this.PnlAssignment.Controls.Add(this.LblAssignmentPrgrss);
            this.PnlAssignment.Controls.Add(this.LblAssignmentPrcntCmplt);
            this.PnlAssignment.Controls.Add(this.ChkbxAssignmentDateReached);
            this.PnlAssignment.Controls.Add(this.DtePkrAssignmentDueDate);
            this.PnlAssignment.Controls.Add(this.LblAssignmentDueDate);
            this.PnlAssignment.Location = new System.Drawing.Point(-1, 60);
            this.PnlAssignment.Name = "PnlAssignment";
            this.PnlAssignment.Size = new System.Drawing.Size(396, 69);
            this.PnlAssignment.TabIndex = 4;
            this.PnlAssignment.Visible = false;
            // 
            // PrgTrkBrAssignmentPrcntCmplt
            // 
            this.PrgTrkBrAssignmentPrcntCmplt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrgTrkBrAssignmentPrcntCmplt.Enabled = false;
            this.PrgTrkBrAssignmentPrcntCmplt.Location = new System.Drawing.Point(15, 40);
            this.PrgTrkBrAssignmentPrcntCmplt.Maximum = 100;
            this.PrgTrkBrAssignmentPrcntCmplt.Minimum = 0;
            this.PrgTrkBrAssignmentPrcntCmplt.Name = "PrgTrkBrAssignmentPrcntCmplt";
            this.PrgTrkBrAssignmentPrcntCmplt.Size = new System.Drawing.Size(330, 28);
            this.PrgTrkBrAssignmentPrcntCmplt.TabIndex = 8;
            this.PrgTrkBrAssignmentPrcntCmplt.TrackBarValue = 0;
            // 
            // LblAssignmentPrgrss
            // 
            this.LblAssignmentPrgrss.AutoSize = true;
            this.LblAssignmentPrgrss.Location = new System.Drawing.Point(353, 47);
            this.LblAssignmentPrgrss.Name = "LblAssignmentPrgrss";
            this.LblAssignmentPrgrss.Size = new System.Drawing.Size(21, 13);
            this.LblAssignmentPrgrss.TabIndex = 8;
            this.LblAssignmentPrgrss.Text = "0%";
            // 
            // LblAssignmentPrcntCmplt
            // 
            this.LblAssignmentPrcntCmplt.AutoSize = true;
            this.LblAssignmentPrcntCmplt.Location = new System.Drawing.Point(153, 28);
            this.LblAssignmentPrcntCmplt.Name = "LblAssignmentPrcntCmplt";
            this.LblAssignmentPrcntCmplt.Size = new System.Drawing.Size(109, 13);
            this.LblAssignmentPrcntCmplt.TabIndex = 14;
            this.LblAssignmentPrcntCmplt.Text = "Percentage Complete";
            // 
            // ChkbxAssignmentDateReached
            // 
            this.ChkbxAssignmentDateReached.AutoSize = true;
            this.ChkbxAssignmentDateReached.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkbxAssignmentDateReached.Enabled = false;
            this.ChkbxAssignmentDateReached.Location = new System.Drawing.Point(247, 7);
            this.ChkbxAssignmentDateReached.Name = "ChkbxAssignmentDateReached";
            this.ChkbxAssignmentDateReached.Size = new System.Drawing.Size(122, 17);
            this.ChkbxAssignmentDateReached.TabIndex = 13;
            this.ChkbxAssignmentDateReached.Text = "Due Date Reached:";
            this.ChkbxAssignmentDateReached.UseVisualStyleBackColor = true;
            // 
            // DtePkrAssignmentDueDate
            // 
            this.DtePkrAssignmentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtePkrAssignmentDueDate.Location = new System.Drawing.Point(66, 5);
            this.DtePkrAssignmentDueDate.Name = "DtePkrAssignmentDueDate";
            this.DtePkrAssignmentDueDate.Size = new System.Drawing.Size(108, 20);
            this.DtePkrAssignmentDueDate.TabIndex = 12;
            this.DtePkrAssignmentDueDate.Value = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            this.DtePkrAssignmentDueDate.ValueChanged += new System.EventHandler(this.DtePkrAssignmentDueDate_ValueChanged);
            // 
            // LblAssignmentDueDate
            // 
            this.LblAssignmentDueDate.AutoSize = true;
            this.LblAssignmentDueDate.Location = new System.Drawing.Point(12, 8);
            this.LblAssignmentDueDate.Name = "LblAssignmentDueDate";
            this.LblAssignmentDueDate.Size = new System.Drawing.Size(56, 13);
            this.LblAssignmentDueDate.TabIndex = 8;
            this.LblAssignmentDueDate.Text = "Due Date:";
            // 
            // PnlTest
            // 
            this.PnlTest.Controls.Add(this.DtePkrTestDate);
            this.PnlTest.Controls.Add(this.TxtbxTestSeat);
            this.PnlTest.Controls.Add(this.LblTestSeat);
            this.PnlTest.Controls.Add(this.TxtbxTestRoom);
            this.PnlTest.Controls.Add(this.LblTestRoom);
            this.PnlTest.Controls.Add(this.LblTestMinutes);
            this.PnlTest.Controls.Add(this.LblTestDuration);
            this.PnlTest.Controls.Add(this.NUDTestDuration);
            this.PnlTest.Controls.Add(this.LblTestDate);
            this.PnlTest.Location = new System.Drawing.Point(-1, 60);
            this.PnlTest.Name = "PnlTest";
            this.PnlTest.Size = new System.Drawing.Size(396, 69);
            this.PnlTest.TabIndex = 5;
            this.PnlTest.Visible = false;
            // 
            // DtePkrTestDate
            // 
            this.DtePkrTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtePkrTestDate.Location = new System.Drawing.Point(66, 9);
            this.DtePkrTestDate.Name = "DtePkrTestDate";
            this.DtePkrTestDate.Size = new System.Drawing.Size(108, 20);
            this.DtePkrTestDate.TabIndex = 14;
            this.DtePkrTestDate.Value = new System.DateTime(2016, 4, 3, 0, 0, 0, 0);
            // 
            // TxtbxTestSeat
            // 
            this.TxtbxTestSeat.Location = new System.Drawing.Point(271, 34);
            this.TxtbxTestSeat.Name = "TxtbxTestSeat";
            this.TxtbxTestSeat.Size = new System.Drawing.Size(108, 20);
            this.TxtbxTestSeat.TabIndex = 13;
            // 
            // LblTestSeat
            // 
            this.LblTestSeat.AutoSize = true;
            this.LblTestSeat.Location = new System.Drawing.Point(230, 37);
            this.LblTestSeat.Name = "LblTestSeat";
            this.LblTestSeat.Size = new System.Drawing.Size(32, 13);
            this.LblTestSeat.TabIndex = 12;
            this.LblTestSeat.Text = "Seat:";
            // 
            // TxtbxTestRoom
            // 
            this.TxtbxTestRoom.Location = new System.Drawing.Point(271, 9);
            this.TxtbxTestRoom.Name = "TxtbxTestRoom";
            this.TxtbxTestRoom.Size = new System.Drawing.Size(108, 20);
            this.TxtbxTestRoom.TabIndex = 11;
            // 
            // LblTestRoom
            // 
            this.LblTestRoom.AutoSize = true;
            this.LblTestRoom.Location = new System.Drawing.Point(230, 12);
            this.LblTestRoom.Name = "LblTestRoom";
            this.LblTestRoom.Size = new System.Drawing.Size(38, 13);
            this.LblTestRoom.TabIndex = 10;
            this.LblTestRoom.Text = "Room:";
            // 
            // LblTestMinutes
            // 
            this.LblTestMinutes.AutoSize = true;
            this.LblTestMinutes.Location = new System.Drawing.Point(174, 38);
            this.LblTestMinutes.Name = "LblTestMinutes";
            this.LblTestMinutes.Size = new System.Drawing.Size(43, 13);
            this.LblTestMinutes.TabIndex = 9;
            this.LblTestMinutes.Text = "minutes";
            // 
            // LblTestDuration
            // 
            this.LblTestDuration.AutoSize = true;
            this.LblTestDuration.Location = new System.Drawing.Point(12, 38);
            this.LblTestDuration.Name = "LblTestDuration";
            this.LblTestDuration.Size = new System.Drawing.Size(50, 13);
            this.LblTestDuration.TabIndex = 8;
            this.LblTestDuration.Text = "Duration:";
            // 
            // NUDTestDuration
            // 
            this.NUDTestDuration.Location = new System.Drawing.Point(66, 35);
            this.NUDTestDuration.Name = "NUDTestDuration";
            this.NUDTestDuration.Size = new System.Drawing.Size(108, 20);
            this.NUDTestDuration.TabIndex = 7;
            // 
            // LblTestDate
            // 
            this.LblTestDate.AutoSize = true;
            this.LblTestDate.Location = new System.Drawing.Point(12, 12);
            this.LblTestDate.Name = "LblTestDate";
            this.LblTestDate.Size = new System.Drawing.Size(33, 13);
            this.LblTestDate.TabIndex = 0;
            this.LblTestDate.Text = "Date:";
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(173, 146);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(35, 17);
            this.LblText.TabIndex = 6;
            this.LblText.Text = "Text";
            // 
            // TxtbxText
            // 
            this.TxtbxText.Location = new System.Drawing.Point(-1, 166);
            this.TxtbxText.Multiline = true;
            this.TxtbxText.Name = "TxtbxText";
            this.TxtbxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtbxText.Size = new System.Drawing.Size(387, 106);
            this.TxtbxText.TabIndex = 7;
            // 
            // LblAssessmentType
            // 
            this.LblAssessmentType.AutoSize = true;
            this.LblAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssessmentType.Location = new System.Drawing.Point(164, 8);
            this.LblAssessmentType.Name = "LblAssessmentType";
            this.LblAssessmentType.Size = new System.Drawing.Size(84, 17);
            this.LblAssessmentType.TabIndex = 8;
            this.LblAssessmentType.Text = "Assessment";
            // 
            // BtnNotes
            // 
            this.BtnNotes.Location = new System.Drawing.Point(292, 274);
            this.BtnNotes.Name = "BtnNotes";
            this.BtnNotes.Size = new System.Drawing.Size(99, 23);
            this.BtnNotes.TabIndex = 9;
            this.BtnNotes.Text = "Notes >";
            this.BtnNotes.UseVisualStyleBackColor = true;
            this.BtnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(110, 274);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(157, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(-1, 274);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(98, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAssessmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(386, 297);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNotes);
            this.Controls.Add(this.LblAssessmentType);
            this.Controls.Add(this.PnlTest);
            this.Controls.Add(this.PnlAssignment);
            this.Controls.Add(this.TxtbxTitle);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.TxtbxText);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtbxModule);
            this.Controls.Add(this.LblModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssessmentDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Assessment Details";
            this.Activated += new System.EventHandler(this.FrmAssessmentDetails_Activated);
            this.Load += new System.EventHandler(this.FrmAssessmentDetails_Load);
            this.LocationChanged += new System.EventHandler(this.FrmAssessmentDetails_LocationChanged);
            this.PnlAssignment.ResumeLayout(false);
            this.PnlAssignment.PerformLayout();
            this.PnlTest.ResumeLayout(false);
            this.PnlTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTestDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblModule;
        private System.Windows.Forms.TextBox TxtbxModule;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtbxTitle;
        private System.Windows.Forms.Panel PnlAssignment;
        private System.Windows.Forms.Panel PnlTest;
        private System.Windows.Forms.Label LblTestDate;
        private System.Windows.Forms.Label LblTestMinutes;
        private System.Windows.Forms.Label LblTestDuration;
        private System.Windows.Forms.NumericUpDown NUDTestDuration;
        private System.Windows.Forms.Label LblAssignmentPrcntCmplt;
        private System.Windows.Forms.CheckBox ChkbxAssignmentDateReached;
        private System.Windows.Forms.DateTimePicker DtePkrAssignmentDueDate;
        private System.Windows.Forms.Label LblAssignmentDueDate;
        private System.Windows.Forms.TextBox TxtbxTestSeat;
        private System.Windows.Forms.Label LblTestSeat;
        private System.Windows.Forms.TextBox TxtbxTestRoom;
        private System.Windows.Forms.Label LblTestRoom;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TextBox TxtbxText;
        private System.Windows.Forms.Label LblAssignmentPrgrss;
        private PrgTrkBr PrgTrkBrAssignmentPrcntCmplt;
        private System.Windows.Forms.Label LblAssessmentType;
        private System.Windows.Forms.Button BtnNotes;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtePkrTestDate;
    }
}