namespace ModNote
{
    partial class PrgTrkBr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.btnThumb = new System.Windows.Forms.Button();
            this.pnlTrack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            this.pnlTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.BackColor = System.Drawing.Color.ForestGreen;
            this.pbProgress.Location = new System.Drawing.Point(0, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(0, 17);
            this.pbProgress.TabIndex = 0;
            this.pbProgress.TabStop = false;
            // 
            // btnThumb
            // 
            this.btnThumb.Enabled = false;
            this.btnThumb.Location = new System.Drawing.Point(0, 0);
            this.btnThumb.Name = "btnThumb";
            this.btnThumb.Size = new System.Drawing.Size(14, 28);
            this.btnThumb.TabIndex = 3;
            this.btnThumb.UseVisualStyleBackColor = true;
            // 
            // pnlTrack
            // 
            this.pnlTrack.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTrack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTrack.Controls.Add(this.pbProgress);
            this.pnlTrack.Enabled = false;
            this.pnlTrack.Location = new System.Drawing.Point(2, 9);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(195, 10);
            this.pnlTrack.TabIndex = 4;
            // 
            // PrgTrkBr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThumb);
            this.Controls.Add(this.pnlTrack);
            this.DoubleBuffered = true;
            this.Name = "PrgTrkBr";
            this.Size = new System.Drawing.Size(198, 28);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressTrackBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressTrackBar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressTrackBar_MouseUp);
            this.Resize += new System.EventHandler(this.ProgressTrackBar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            this.pnlTrack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProgress;
        private System.Windows.Forms.Button btnThumb;
        private System.Windows.Forms.Panel pnlTrack;
    }
}
