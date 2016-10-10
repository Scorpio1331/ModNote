namespace ModNote
{
    partial class FrmModuleDetails
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
            this.OpnFlDlgModuleSelector = new System.Windows.Forms.OpenFileDialog();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNotes = new System.Windows.Forms.Button();
            this.TxtbxTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtbxModuleCode = new System.Windows.Forms.TextBox();
            this.LblModuleCode = new System.Windows.Forms.Label();
            this.BtnAssessments = new System.Windows.Forms.Button();
            this.TxtbxSynopsis = new System.Windows.Forms.TextBox();
            this.LblSynopsis = new System.Windows.Forms.Label();
            this.LblLearningObj = new System.Windows.Forms.Label();
            this.LstVwLearningObj = new System.Windows.Forms.ListView();
            this.BtnAssessmentQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpnFlDlgModuleSelector
            // 
            this.OpnFlDlgModuleSelector.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.OpnFlDlgModuleSelector.Title = "Select Module";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(98, 23);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(139, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(217, 23);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNotes
            // 
            this.BtnNotes.Location = new System.Drawing.Point(375, 178);
            this.BtnNotes.Name = "BtnNotes";
            this.BtnNotes.Size = new System.Drawing.Size(99, 23);
            this.BtnNotes.TabIndex = 21;
            this.BtnNotes.Text = "Notes >";
            this.BtnNotes.UseVisualStyleBackColor = true;
            this.BtnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
            // 
            // TxtbxTitle
            // 
            this.TxtbxTitle.Location = new System.Drawing.Point(297, 15);
            this.TxtbxTitle.Name = "TxtbxTitle";
            this.TxtbxTitle.Size = new System.Drawing.Size(177, 20);
            this.TxtbxTitle.TabIndex = 15;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(261, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Title:";
            // 
            // TxtbxModuleCode
            // 
            this.TxtbxModuleCode.Location = new System.Drawing.Point(60, 15);
            this.TxtbxModuleCode.Name = "TxtbxModuleCode";
            this.TxtbxModuleCode.Size = new System.Drawing.Size(166, 20);
            this.TxtbxModuleCode.TabIndex = 13;
            // 
            // LblModuleCode
            // 
            this.LblModuleCode.AutoSize = true;
            this.LblModuleCode.Location = new System.Drawing.Point(6, 18);
            this.LblModuleCode.Name = "LblModuleCode";
            this.LblModuleCode.Size = new System.Drawing.Size(35, 13);
            this.LblModuleCode.TabIndex = 12;
            this.LblModuleCode.Text = "Code:";
            // 
            // BtnAssessments
            // 
            this.BtnAssessments.Location = new System.Drawing.Point(375, 149);
            this.BtnAssessments.Name = "BtnAssessments";
            this.BtnAssessments.Size = new System.Drawing.Size(99, 23);
            this.BtnAssessments.TabIndex = 24;
            this.BtnAssessments.Text = "Assessments >";
            this.BtnAssessments.UseVisualStyleBackColor = true;
            this.BtnAssessments.Click += new System.EventHandler(this.BtnAssessments_Click);
            // 
            // TxtbxSynopsis
            // 
            this.TxtbxSynopsis.Location = new System.Drawing.Point(60, 41);
            this.TxtbxSynopsis.Multiline = true;
            this.TxtbxSynopsis.Name = "TxtbxSynopsis";
            this.TxtbxSynopsis.Size = new System.Drawing.Size(414, 36);
            this.TxtbxSynopsis.TabIndex = 26;
            // 
            // LblSynopsis
            // 
            this.LblSynopsis.AutoSize = true;
            this.LblSynopsis.Location = new System.Drawing.Point(6, 51);
            this.LblSynopsis.Name = "LblSynopsis";
            this.LblSynopsis.Size = new System.Drawing.Size(49, 13);
            this.LblSynopsis.TabIndex = 25;
            this.LblSynopsis.Text = "Synopsis";
            // 
            // LblLearningObj
            // 
            this.LblLearningObj.Location = new System.Drawing.Point(6, 96);
            this.LblLearningObj.Name = "LblLearningObj";
            this.LblLearningObj.Size = new System.Drawing.Size(64, 29);
            this.LblLearningObj.TabIndex = 27;
            this.LblLearningObj.Text = "Learning Objectives";
            // 
            // LstVwLearningObj
            // 
            this.LstVwLearningObj.LabelEdit = true;
            this.LstVwLearningObj.LabelWrap = false;
            this.LstVwLearningObj.Location = new System.Drawing.Point(60, 83);
            this.LstVwLearningObj.Name = "LstVwLearningObj";
            this.LstVwLearningObj.ShowGroups = false;
            this.LstVwLearningObj.Size = new System.Drawing.Size(414, 60);
            this.LstVwLearningObj.TabIndex = 28;
            this.LstVwLearningObj.UseCompatibleStateImageBehavior = false;
            this.LstVwLearningObj.View = System.Windows.Forms.View.List;
            // 
            // BtnAssessmentQueue
            // 
            this.BtnAssessmentQueue.Location = new System.Drawing.Point(251, 149);
            this.BtnAssessmentQueue.Name = "BtnAssessmentQueue";
            this.BtnAssessmentQueue.Size = new System.Drawing.Size(118, 23);
            this.BtnAssessmentQueue.TabIndex = 29;
            this.BtnAssessmentQueue.Text = "Assessment Queue";
            this.BtnAssessmentQueue.UseVisualStyleBackColor = true;
            this.BtnAssessmentQueue.Visible = false;
            this.BtnAssessmentQueue.Click += new System.EventHandler(this.BtnAssessmentQueue_Click);
            // 
            // FrmModuleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(474, 202);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAssessmentQueue);
            this.Controls.Add(this.LstVwLearningObj);
            this.Controls.Add(this.LblLearningObj);
            this.Controls.Add(this.TxtbxSynopsis);
            this.Controls.Add(this.LblSynopsis);
            this.Controls.Add(this.BtnAssessments);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNotes);
            this.Controls.Add(this.TxtbxTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtbxModuleCode);
            this.Controls.Add(this.LblModuleCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModuleDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module Details";
            this.Activated += new System.EventHandler(this.FrmModuleDetails_Activated);
            this.Load += new System.EventHandler(this.FrmModuleDetails_Load);
            this.LocationChanged += new System.EventHandler(this.FrmModuleDetails_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpnFlDlgModuleSelector;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNotes;
        private System.Windows.Forms.TextBox TxtbxTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtbxModuleCode;
        private System.Windows.Forms.Label LblModuleCode;
        private System.Windows.Forms.Button BtnAssessments;
        private System.Windows.Forms.TextBox TxtbxSynopsis;
        private System.Windows.Forms.Label LblSynopsis;
        private System.Windows.Forms.Label LblLearningObj;
        private System.Windows.Forms.ListView LstVwLearningObj;
        private System.Windows.Forms.Button BtnAssessmentQueue;
    }
}