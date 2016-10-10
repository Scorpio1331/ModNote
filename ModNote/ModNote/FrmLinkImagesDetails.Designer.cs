namespace ModNote
{
    partial class FrmLinkImagesDetails
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
            this.TxtbxURL = new System.Windows.Forms.TextBox();
            this.LblURL = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtbxTitle = new System.Windows.Forms.TextBox();
            this.PnlLink = new System.Windows.Forms.Panel();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.TxtbxFilePath = new System.Windows.Forms.TextBox();
            this.BtnFileExplorer = new System.Windows.Forms.Button();
            this.TxtbxCaption = new System.Windows.Forms.TextBox();
            this.LblImageCaption = new System.Windows.Forms.Label();
            this.OpnFlDlgFindImage = new System.Windows.Forms.OpenFileDialog();
            this.PnlLink.SuspendLayout();
            this.PnlImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtbxURL
            // 
            this.TxtbxURL.Location = new System.Drawing.Point(64, 25);
            this.TxtbxURL.Name = "TxtbxURL";
            this.TxtbxURL.Size = new System.Drawing.Size(218, 20);
            this.TxtbxURL.TabIndex = 0;
            // 
            // LblURL
            // 
            this.LblURL.AutoSize = true;
            this.LblURL.Location = new System.Drawing.Point(4, 28);
            this.LblURL.Name = "LblURL";
            this.LblURL.Size = new System.Drawing.Size(55, 13);
            this.LblURL.TabIndex = 1;
            this.LblURL.Text = "Link URL:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 51);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(115, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(157, 51);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(115, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(4, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(53, 13);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Link Title:";
            // 
            // TxtbxTitle
            // 
            this.TxtbxTitle.Location = new System.Drawing.Point(64, 2);
            this.TxtbxTitle.Name = "TxtbxTitle";
            this.TxtbxTitle.Size = new System.Drawing.Size(218, 20);
            this.TxtbxTitle.TabIndex = 5;
            // 
            // PnlLink
            // 
            this.PnlLink.Controls.Add(this.TxtbxTitle);
            this.PnlLink.Controls.Add(this.LblTitle);
            this.PnlLink.Controls.Add(this.TxtbxURL);
            this.PnlLink.Controls.Add(this.LblURL);
            this.PnlLink.Location = new System.Drawing.Point(0, 2);
            this.PnlLink.Name = "PnlLink";
            this.PnlLink.Size = new System.Drawing.Size(282, 45);
            this.PnlLink.TabIndex = 6;
            // 
            // PnlImage
            // 
            this.PnlImage.Controls.Add(this.TxtbxFilePath);
            this.PnlImage.Controls.Add(this.BtnFileExplorer);
            this.PnlImage.Controls.Add(this.TxtbxCaption);
            this.PnlImage.Controls.Add(this.LblImageCaption);
            this.PnlImage.Location = new System.Drawing.Point(0, 1);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(282, 45);
            this.PnlImage.TabIndex = 7;
            // 
            // TxtbxFilePath
            // 
            this.TxtbxFilePath.Location = new System.Drawing.Point(79, 23);
            this.TxtbxFilePath.Name = "TxtbxFilePath";
            this.TxtbxFilePath.Size = new System.Drawing.Size(203, 20);
            this.TxtbxFilePath.TabIndex = 9;
            // 
            // BtnFileExplorer
            // 
            this.BtnFileExplorer.Location = new System.Drawing.Point(5, 22);
            this.BtnFileExplorer.Name = "BtnFileExplorer";
            this.BtnFileExplorer.Size = new System.Drawing.Size(72, 21);
            this.BtnFileExplorer.TabIndex = 8;
            this.BtnFileExplorer.Text = "File Explorer";
            this.BtnFileExplorer.UseVisualStyleBackColor = true;
            this.BtnFileExplorer.Click += new System.EventHandler(this.BtnFileExplorer_Click);
            // 
            // TxtbxCaption
            // 
            this.TxtbxCaption.Location = new System.Drawing.Point(79, 2);
            this.TxtbxCaption.Name = "TxtbxCaption";
            this.TxtbxCaption.Size = new System.Drawing.Size(203, 20);
            this.TxtbxCaption.TabIndex = 5;
            // 
            // LblImageCaption
            // 
            this.LblImageCaption.AutoSize = true;
            this.LblImageCaption.Location = new System.Drawing.Point(4, 5);
            this.LblImageCaption.Name = "LblImageCaption";
            this.LblImageCaption.Size = new System.Drawing.Size(78, 13);
            this.LblImageCaption.TabIndex = 4;
            this.LblImageCaption.Text = "Image Caption:";
            // 
            // OpnFlDlgFindImage
            // 
            this.OpnFlDlgFindImage.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Fi" +
    "les (*.gif)|*.gif";
            this.OpnFlDlgFindImage.InitialDirectory = "Pictures";
            this.OpnFlDlgFindImage.Title = "Image Selector";
            // 
            // FrmLinkImagesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.ControlBox = false;
            this.Controls.Add(this.PnlImage);
            this.Controls.Add(this.PnlLink);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLinkImagesDetails";
            this.Text = "Enter Link URL";
            this.PnlLink.ResumeLayout(false);
            this.PnlLink.PerformLayout();
            this.PnlImage.ResumeLayout(false);
            this.PnlImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxURL;
        private System.Windows.Forms.Label LblURL;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtbxTitle;
        private System.Windows.Forms.Panel PnlLink;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.TextBox TxtbxFilePath;
        private System.Windows.Forms.Button BtnFileExplorer;
        private System.Windows.Forms.TextBox TxtbxCaption;
        private System.Windows.Forms.Label LblImageCaption;
        private System.Windows.Forms.OpenFileDialog OpnFlDlgFindImage;
    }
}