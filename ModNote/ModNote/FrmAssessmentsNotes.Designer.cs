namespace ModNote
{
    partial class FrmAssessmentsNotes
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
            this.FlwLytPnlAssessmentsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.PnlAddButton = new System.Windows.Forms.Panel();
            this.PnlBorder = new System.Windows.Forms.Panel();
            this.CntxtMnuStrpItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TlStrpMnuItmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.FlwLytPnlNotesGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlAddButton.SuspendLayout();
            this.PnlBorder.SuspendLayout();
            this.CntxtMnuStrpItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlwLytPnlAssessmentsGrid
            // 
            this.FlwLytPnlAssessmentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwLytPnlAssessmentsGrid.Location = new System.Drawing.Point(0, 0);
            this.FlwLytPnlAssessmentsGrid.Name = "FlwLytPnlAssessmentsGrid";
            this.FlwLytPnlAssessmentsGrid.Size = new System.Drawing.Size(282, 235);
            this.FlwLytPnlAssessmentsGrid.TabIndex = 0;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddItem.Location = new System.Drawing.Point(0, 0);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(282, 24);
            this.BtnAddItem.TabIndex = 0;
            this.BtnAddItem.Text = "Add";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddNoteAssessment_Click);
            // 
            // PnlAddButton
            // 
            this.PnlAddButton.Controls.Add(this.BtnAddItem);
            this.PnlAddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAddButton.Location = new System.Drawing.Point(0, 235);
            this.PnlAddButton.Name = "PnlAddButton";
            this.PnlAddButton.Size = new System.Drawing.Size(282, 24);
            this.PnlAddButton.TabIndex = 2;
            // 
            // PnlBorder
            // 
            this.PnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBorder.Controls.Add(this.FlwLytPnlNotesGrid);
            this.PnlBorder.Controls.Add(this.FlwLytPnlAssessmentsGrid);
            this.PnlBorder.Controls.Add(this.PnlAddButton);
            this.PnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBorder.Location = new System.Drawing.Point(0, 0);
            this.PnlBorder.Name = "PnlBorder";
            this.PnlBorder.Size = new System.Drawing.Size(284, 261);
            this.PnlBorder.TabIndex = 0;
            // 
            // CntxtMnuStrpItems
            // 
            this.CntxtMnuStrpItems.AllowMerge = false;
            this.CntxtMnuStrpItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpMnuItmDelete});
            this.CntxtMnuStrpItems.Name = "CntxtMnuStrpLinks";
            this.CntxtMnuStrpItems.Size = new System.Drawing.Size(108, 26);
            // 
            // TlStrpMnuItmDelete
            // 
            this.TlStrpMnuItmDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpMnuItmDelete.Name = "TlStrpMnuItmDelete";
            this.TlStrpMnuItmDelete.Size = new System.Drawing.Size(107, 22);
            this.TlStrpMnuItmDelete.Text = "Delete";
            this.TlStrpMnuItmDelete.Click += new System.EventHandler(this.TlStrpMnuItmDeleteNote_Click);
            // 
            // FlwLytPnlNotesGrid
            // 
            this.FlwLytPnlNotesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwLytPnlNotesGrid.Location = new System.Drawing.Point(0, 0);
            this.FlwLytPnlNotesGrid.Name = "FlwLytPnlNotesGrid";
            this.FlwLytPnlNotesGrid.Size = new System.Drawing.Size(282, 235);
            this.FlwLytPnlNotesGrid.TabIndex = 3;
            // 
            // FrmAssessmentsNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.PnlBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssessmentsNotes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notes";
            this.PnlAddButton.ResumeLayout(false);
            this.PnlBorder.ResumeLayout(false);
            this.CntxtMnuStrpItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlAssessmentsGrid;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Panel PnlAddButton;
        private System.Windows.Forms.Panel PnlBorder;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuStrpItems;
        private System.Windows.Forms.ToolStripMenuItem TlStrpMnuItmDelete;
        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlNotesGrid;
    }
}