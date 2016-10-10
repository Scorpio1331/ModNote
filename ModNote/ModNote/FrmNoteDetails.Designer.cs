namespace ModNote
{
    partial class FrmNoteDetails
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
            this.components = new System.ComponentModel.Container();
            this.TxtbxTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.TxtbxText = new System.Windows.Forms.TextBox();
            this.LblImages = new System.Windows.Forms.Label();
            this.FlwLytPnlImages = new System.Windows.Forms.FlowLayoutPanel();
            this.LblLinks = new System.Windows.Forms.Label();
            this.BtnAddLink = new System.Windows.Forms.Button();
            this.FlwLytPnlLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.CntxtMnuStrpLinks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TlStrpMnuItmDeleteLink = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.CntxtMnuStrpImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TlStrpMnuItmDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtMnuStrpLinks.SuspendLayout();
            this.CntxtMnuStrpImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtbxTitle
            // 
            this.TxtbxTitle.Location = new System.Drawing.Point(88, 12);
            this.TxtbxTitle.Name = "TxtbxTitle";
            this.TxtbxTitle.Size = new System.Drawing.Size(108, 20);
            this.TxtbxTitle.TabIndex = 5;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(55, 15);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Title:";
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(121, 39);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(35, 17);
            this.LblText.TabIndex = 8;
            this.LblText.Text = "Text";
            // 
            // TxtbxText
            // 
            this.TxtbxText.Location = new System.Drawing.Point(-2, 59);
            this.TxtbxText.Multiline = true;
            this.TxtbxText.Name = "TxtbxText";
            this.TxtbxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtbxText.Size = new System.Drawing.Size(288, 106);
            this.TxtbxText.TabIndex = 9;
            // 
            // LblImages
            // 
            this.LblImages.AutoSize = true;
            this.LblImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImages.Location = new System.Drawing.Point(121, 168);
            this.LblImages.Name = "LblImages";
            this.LblImages.Size = new System.Drawing.Size(53, 17);
            this.LblImages.TabIndex = 10;
            this.LblImages.Text = "Images";
            // 
            // FlwLytPnlImages
            // 
            this.FlwLytPnlImages.AutoScroll = true;
            this.FlwLytPnlImages.Location = new System.Drawing.Point(-2, 188);
            this.FlwLytPnlImages.Name = "FlwLytPnlImages";
            this.FlwLytPnlImages.Size = new System.Drawing.Size(230, 75);
            this.FlwLytPnlImages.TabIndex = 11;
            // 
            // LblLinks
            // 
            this.LblLinks.AutoSize = true;
            this.LblLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinks.Location = new System.Drawing.Point(121, 266);
            this.LblLinks.Name = "LblLinks";
            this.LblLinks.Size = new System.Drawing.Size(41, 17);
            this.LblLinks.TabIndex = 12;
            this.LblLinks.Text = "Links";
            // 
            // BtnAddLink
            // 
            this.BtnAddLink.Location = new System.Drawing.Point(227, 285);
            this.BtnAddLink.Name = "BtnAddLink";
            this.BtnAddLink.Size = new System.Drawing.Size(58, 62);
            this.BtnAddLink.TabIndex = 14;
            this.BtnAddLink.Text = "Add Link";
            this.BtnAddLink.UseVisualStyleBackColor = true;
            this.BtnAddLink.Click += new System.EventHandler(this.BtnAddLink_Click);
            // 
            // FlwLytPnlLinks
            // 
            this.FlwLytPnlLinks.AutoScroll = true;
            this.FlwLytPnlLinks.Location = new System.Drawing.Point(-1, 286);
            this.FlwLytPnlLinks.Name = "FlwLytPnlLinks";
            this.FlwLytPnlLinks.Size = new System.Drawing.Size(229, 60);
            this.FlwLytPnlLinks.TabIndex = 12;
            // 
            // CntxtMnuStrpLinks
            // 
            this.CntxtMnuStrpLinks.AllowMerge = false;
            this.CntxtMnuStrpLinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMnuItmDeleteLink});
            this.CntxtMnuStrpLinks.Name = "CntxtMnuStrpLinks";
            this.CntxtMnuStrpLinks.Size = new System.Drawing.Size(133, 26);
            // 
            // TlStrpMnuItmDeleteLink
            // 
            this.TlStrpMnuItmDeleteLink.Name = "TlStrpMnuItmDeleteLink";
            this.TlStrpMnuItmDeleteLink.Size = new System.Drawing.Size(132, 22);
            this.TlStrpMnuItmDeleteLink.Text = "Delete Link";
            this.TlStrpMnuItmDeleteLink.Click += new System.EventHandler(this.TlStrpMnuItmDeleteLink_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 352);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(98, 23);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(174, 352);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 23);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(227, 187);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(58, 77);
            this.AddImage.TabIndex = 18;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // CntxtMnuStrpImages
            // 
            this.CntxtMnuStrpImages.AllowMerge = false;
            this.CntxtMnuStrpImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMnuItmDeleteImage});
            this.CntxtMnuStrpImages.Name = "CntxtMnuStrpLinks";
            this.CntxtMnuStrpImages.Size = new System.Drawing.Size(144, 26);
            // 
            // TlStrpMnuItmDeleteImage
            // 
            this.TlStrpMnuItmDeleteImage.Name = "TlStrpMnuItmDeleteImage";
            this.TlStrpMnuItmDeleteImage.Size = new System.Drawing.Size(143, 22);
            this.TlStrpMnuItmDeleteImage.Text = "Delete Image";
            this.TlStrpMnuItmDeleteImage.Click += new System.EventHandler(this.TlStrpMnuItmDeleteImage_Click);
            // 
            // FrmNoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.ControlBox = false;
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.FlwLytPnlLinks);
            this.Controls.Add(this.BtnAddLink);
            this.Controls.Add(this.LblLinks);
            this.Controls.Add(this.FlwLytPnlImages);
            this.Controls.Add(this.LblImages);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.TxtbxText);
            this.Controls.Add(this.TxtbxTitle);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNoteDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Note Details";
            this.Load += new System.EventHandler(this.FrmNoteDetails_Load);
            this.CntxtMnuStrpLinks.ResumeLayout(false);
            this.CntxtMnuStrpImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TextBox TxtbxText;
        private System.Windows.Forms.Label LblImages;
        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlImages;
        private System.Windows.Forms.Label LblLinks;
        private System.Windows.Forms.Button BtnAddLink;
        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlLinks;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuStrpLinks;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMnuItmDeleteLink;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuStrpImages;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMnuItmDeleteImage;
    }
}