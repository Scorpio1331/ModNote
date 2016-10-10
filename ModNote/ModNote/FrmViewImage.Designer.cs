namespace ModNote
{
    partial class FrmViewImage
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
            this.PctrbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctrbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PctrbxImage
            // 
            this.PctrbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PctrbxImage.Location = new System.Drawing.Point(0, 0);
            this.PctrbxImage.Name = "PctrbxImage";
            this.PctrbxImage.Size = new System.Drawing.Size(462, 313);
            this.PctrbxImage.TabIndex = 0;
            this.PctrbxImage.TabStop = false;
            // 
            // FrmViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.PctrbxImage);
            this.Name = "FrmViewImage";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.PctrbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctrbxImage;
    }
}