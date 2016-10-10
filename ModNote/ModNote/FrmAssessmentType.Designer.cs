namespace ModNote
{
    partial class FrmAssessmentType
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
            this.LblQuestion = new System.Windows.Forms.Label();
            this.BtnAssignment = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(12, 9);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(239, 20);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "Please choose Assessment type";
            // 
            // BtnAssignment
            // 
            this.BtnAssignment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAssignment.Location = new System.Drawing.Point(12, 32);
            this.BtnAssignment.Name = "BtnAssignment";
            this.BtnAssignment.Size = new System.Drawing.Size(112, 23);
            this.BtnAssignment.TabIndex = 1;
            this.BtnAssignment.Text = "Assignment";
            this.BtnAssignment.UseVisualStyleBackColor = true;
            // 
            // BtnTest
            // 
            this.BtnTest.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnTest.Location = new System.Drawing.Point(133, 32);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(112, 23);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            // 
            // FrmAssessmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 60);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnAssignment);
            this.Controls.Add(this.LblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssessmentType";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Assessment type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Button BtnAssignment;
        private System.Windows.Forms.Button BtnTest;
    }
}