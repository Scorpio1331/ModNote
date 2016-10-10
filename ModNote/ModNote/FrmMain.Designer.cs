namespace ModNote
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TlStrpMenu = new System.Windows.Forms.ToolStrip();
            this.TlStrpBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnLoadSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TlStrpBtnLoadModules = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnSaveSettingsModules = new System.Windows.Forms.ToolStripButton();
            this.SpltPnlCntnrModuleAssessmentsHolder = new System.Windows.Forms.SplitContainer();
            this.TrVwModulesList = new System.Windows.Forms.TreeView();
            this.LblModules = new System.Windows.Forms.Label();
            this.TlBrModulesPnl = new System.Windows.Forms.ToolStrip();
            this.TlStrpBtnAddModule = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnDeleteModule = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnMdlDeleteAssessment = new System.Windows.Forms.ToolStripButton();
            this.TrVwUpcomingAssessments = new System.Windows.Forms.TreeView();
            this.LblUpComingAssessments = new System.Windows.Forms.Label();
            this.AssessmentPnlToolBar = new System.Windows.Forms.ToolStrip();
            this.TlStrpBtnDeleteAssessment = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnViewAll = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnSort = new System.Windows.Forms.ToolStripButton();
            this.OpnFlDlgModuleSelector = new System.Windows.Forms.OpenFileDialog();
            this.TlStrpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpltPnlCntnrModuleAssessmentsHolder)).BeginInit();
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel1.SuspendLayout();
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel2.SuspendLayout();
            this.SpltPnlCntnrModuleAssessmentsHolder.SuspendLayout();
            this.TlBrModulesPnl.SuspendLayout();
            this.AssessmentPnlToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlStrpMenu
            // 
            this.TlStrpMenu.AutoSize = false;
            this.TlStrpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlStrpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpBtnSettings,
            this.TlStrpBtnLoadSettings,
            this.toolStripSeparator1,
            this.TlStrpBtnLoadModules,
            this.TlStrpBtnSaveSettingsModules});
            this.TlStrpMenu.Location = new System.Drawing.Point(0, 376);
            this.TlStrpMenu.Name = "TlStrpMenu";
            this.TlStrpMenu.Size = new System.Drawing.Size(852, 25);
            this.TlStrpMenu.Stretch = true;
            this.TlStrpMenu.TabIndex = 0;
            // 
            // TlStrpBtnSettings
            // 
            this.TlStrpBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnSettings.Image")));
            this.TlStrpBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnSettings.Name = "TlStrpBtnSettings";
            this.TlStrpBtnSettings.Size = new System.Drawing.Size(53, 22);
            this.TlStrpBtnSettings.Text = "Settings";
            this.TlStrpBtnSettings.Click += new System.EventHandler(this.TlStrpBtnSettings_Click);
            // 
            // TlStrpBtnLoadSettings
            // 
            this.TlStrpBtnLoadSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnLoadSettings.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnLoadSettings.Image")));
            this.TlStrpBtnLoadSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnLoadSettings.Name = "TlStrpBtnLoadSettings";
            this.TlStrpBtnLoadSettings.Size = new System.Drawing.Size(82, 22);
            this.TlStrpBtnLoadSettings.Text = "Load Settings";
            this.TlStrpBtnLoadSettings.Click += new System.EventHandler(this.TlStrpBtnLoadSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TlStrpBtnLoadModules
            // 
            this.TlStrpBtnLoadModules.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnLoadModules.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnLoadModules.Image")));
            this.TlStrpBtnLoadModules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnLoadModules.Name = "TlStrpBtnLoadModules";
            this.TlStrpBtnLoadModules.Size = new System.Drawing.Size(86, 22);
            this.TlStrpBtnLoadModules.Text = "Load Modules";
            this.TlStrpBtnLoadModules.Click += new System.EventHandler(this.TlStrpBtnLoadModules_Click);
            // 
            // TlStrpBtnSaveSettingsModules
            // 
            this.TlStrpBtnSaveSettingsModules.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnSaveSettingsModules.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnSaveSettingsModules.Image")));
            this.TlStrpBtnSaveSettingsModules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnSaveSettingsModules.Name = "TlStrpBtnSaveSettingsModules";
            this.TlStrpBtnSaveSettingsModules.Size = new System.Drawing.Size(152, 22);
            this.TlStrpBtnSaveSettingsModules.Text = "Save Settings and Modules";
            this.TlStrpBtnSaveSettingsModules.Click += new System.EventHandler(this.FrmMain_Closed);
            // 
            // SpltPnlCntnrModuleAssessmentsHolder
            // 
            this.SpltPnlCntnrModuleAssessmentsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpltPnlCntnrModuleAssessmentsHolder.Location = new System.Drawing.Point(0, 0);
            this.SpltPnlCntnrModuleAssessmentsHolder.Name = "SpltPnlCntnrModuleAssessmentsHolder";
            // 
            // SpltPnlCntnrModuleAssessmentsHolder.Panel1
            // 
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel1.Controls.Add(this.TrVwModulesList);
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel1.Controls.Add(this.LblModules);
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel1.Controls.Add(this.TlBrModulesPnl);
            // 
            // SpltPnlCntnrModuleAssessmentsHolder.Panel2
            // 
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel2.Controls.Add(this.TrVwUpcomingAssessments);
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel2.Controls.Add(this.LblUpComingAssessments);
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel2.Controls.Add(this.AssessmentPnlToolBar);
            this.SpltPnlCntnrModuleAssessmentsHolder.Size = new System.Drawing.Size(852, 376);
            this.SpltPnlCntnrModuleAssessmentsHolder.SplitterDistance = 410;
            this.SpltPnlCntnrModuleAssessmentsHolder.SplitterWidth = 2;
            this.SpltPnlCntnrModuleAssessmentsHolder.TabIndex = 3;
            // 
            // TrVwModulesList
            // 
            this.TrVwModulesList.BackColor = System.Drawing.SystemColors.Control;
            this.TrVwModulesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrVwModulesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrVwModulesList.Location = new System.Drawing.Point(0, 24);
            this.TrVwModulesList.Name = "TrVwModulesList";
            this.TrVwModulesList.Size = new System.Drawing.Size(410, 327);
            this.TrVwModulesList.TabIndex = 0;
            this.TrVwModulesList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ModulesListTrVw_NodeMouseDoubleClick);
            // 
            // LblModules
            // 
            this.LblModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModules.Location = new System.Drawing.Point(0, 0);
            this.LblModules.Name = "LblModules";
            this.LblModules.Size = new System.Drawing.Size(410, 24);
            this.LblModules.TabIndex = 4;
            this.LblModules.Text = "Modules";
            // 
            // TlBrModulesPnl
            // 
            this.TlBrModulesPnl.AutoSize = false;
            this.TlBrModulesPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlBrModulesPnl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TlBrModulesPnl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpBtnAddModule,
            this.TlStrpBtnDeleteModule,
            this.TlStrpBtnMdlDeleteAssessment});
            this.TlBrModulesPnl.Location = new System.Drawing.Point(0, 351);
            this.TlBrModulesPnl.Name = "TlBrModulesPnl";
            this.TlBrModulesPnl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TlBrModulesPnl.Size = new System.Drawing.Size(410, 25);
            this.TlBrModulesPnl.Stretch = true;
            this.TlBrModulesPnl.TabIndex = 3;
            // 
            // TlStrpBtnAddModule
            // 
            this.TlStrpBtnAddModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnAddModule.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnAddModule.Image")));
            this.TlStrpBtnAddModule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnAddModule.Name = "TlStrpBtnAddModule";
            this.TlStrpBtnAddModule.Size = new System.Drawing.Size(77, 22);
            this.TlStrpBtnAddModule.Text = "Add Module";
            this.TlStrpBtnAddModule.ToolTipText = "Add Module";
            this.TlStrpBtnAddModule.Click += new System.EventHandler(this.AddModuleBtn_Click);
            // 
            // TlStrpBtnDeleteModule
            // 
            this.TlStrpBtnDeleteModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnDeleteModule.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnDeleteModule.Image")));
            this.TlStrpBtnDeleteModule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnDeleteModule.Name = "TlStrpBtnDeleteModule";
            this.TlStrpBtnDeleteModule.Size = new System.Drawing.Size(88, 22);
            this.TlStrpBtnDeleteModule.Text = "Delete Module";
            this.TlStrpBtnDeleteModule.ToolTipText = "Delete Module";
            this.TlStrpBtnDeleteModule.Click += new System.EventHandler(this.DeleteModuleBtn_Click);
            // 
            // TlStrpBtnMdlDeleteAssessment
            // 
            this.TlStrpBtnMdlDeleteAssessment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnMdlDeleteAssessment.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnMdlDeleteAssessment.Image")));
            this.TlStrpBtnMdlDeleteAssessment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnMdlDeleteAssessment.Name = "TlStrpBtnMdlDeleteAssessment";
            this.TlStrpBtnMdlDeleteAssessment.Size = new System.Drawing.Size(109, 22);
            this.TlStrpBtnMdlDeleteAssessment.Text = "Delete Assessment";
            this.TlStrpBtnMdlDeleteAssessment.ToolTipText = "Delete Assessment";
            this.TlStrpBtnMdlDeleteAssessment.Click += new System.EventHandler(this.TlStrpBtnDeleteAssessment_Click);
            // 
            // TrVwUpcomingAssessments
            // 
            this.TrVwUpcomingAssessments.BackColor = System.Drawing.SystemColors.Control;
            this.TrVwUpcomingAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrVwUpcomingAssessments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrVwUpcomingAssessments.Location = new System.Drawing.Point(0, 24);
            this.TrVwUpcomingAssessments.Name = "TrVwUpcomingAssessments";
            this.TrVwUpcomingAssessments.Size = new System.Drawing.Size(440, 327);
            this.TrVwUpcomingAssessments.TabIndex = 1;
            this.TrVwUpcomingAssessments.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrVwUpcomingAssessments_NodeMouseDoubleClick);
            // 
            // LblUpComingAssessments
            // 
            this.LblUpComingAssessments.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUpComingAssessments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpComingAssessments.Location = new System.Drawing.Point(0, 0);
            this.LblUpComingAssessments.Name = "LblUpComingAssessments";
            this.LblUpComingAssessments.Size = new System.Drawing.Size(440, 24);
            this.LblUpComingAssessments.TabIndex = 5;
            this.LblUpComingAssessments.Text = "Upcoming Assessments";
            // 
            // AssessmentPnlToolBar
            // 
            this.AssessmentPnlToolBar.AutoSize = false;
            this.AssessmentPnlToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AssessmentPnlToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AssessmentPnlToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpBtnDeleteAssessment,
            this.TlStrpBtnViewAll,
            this.TlStrpBtnSort});
            this.AssessmentPnlToolBar.Location = new System.Drawing.Point(0, 351);
            this.AssessmentPnlToolBar.Name = "AssessmentPnlToolBar";
            this.AssessmentPnlToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AssessmentPnlToolBar.Size = new System.Drawing.Size(440, 25);
            this.AssessmentPnlToolBar.Stretch = true;
            this.AssessmentPnlToolBar.TabIndex = 2;
            // 
            // TlStrpBtnDeleteAssessment
            // 
            this.TlStrpBtnDeleteAssessment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnDeleteAssessment.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnDeleteAssessment.Image")));
            this.TlStrpBtnDeleteAssessment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnDeleteAssessment.Name = "TlStrpBtnDeleteAssessment";
            this.TlStrpBtnDeleteAssessment.Size = new System.Drawing.Size(109, 22);
            this.TlStrpBtnDeleteAssessment.Text = "Delete Assessment";
            this.TlStrpBtnDeleteAssessment.ToolTipText = "Delete Assessment";
            this.TlStrpBtnDeleteAssessment.Click += new System.EventHandler(this.TlStrpBtnDeleteAssessment_Click);
            // 
            // TlStrpBtnViewAll
            // 
            this.TlStrpBtnViewAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnViewAll.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnViewAll.Image")));
            this.TlStrpBtnViewAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnViewAll.Name = "TlStrpBtnViewAll";
            this.TlStrpBtnViewAll.Size = new System.Drawing.Size(121, 22);
            this.TlStrpBtnViewAll.Text = "View all Assessments";
            this.TlStrpBtnViewAll.Click += new System.EventHandler(this.TlStrpBtnViewAll_Click);
            // 
            // TlStrpBtnSort
            // 
            this.TlStrpBtnSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrpBtnSort.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpBtnSort.Image")));
            this.TlStrpBtnSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnSort.Name = "TlStrpBtnSort";
            this.TlStrpBtnSort.Size = new System.Drawing.Size(102, 22);
            this.TlStrpBtnSort.Text = "Sort Assessments";
            this.TlStrpBtnSort.Click += new System.EventHandler(this.SortAssessments);
            // 
            // OpnFlDlgModuleSelector
            // 
            this.OpnFlDlgModuleSelector.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.OpnFlDlgModuleSelector.Title = "Select Module";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 401);
            this.Controls.Add(this.SpltPnlCntnrModuleAssessmentsHolder);
            this.Controls.Add(this.TlStrpMenu);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "modnote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_Closed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TlStrpMenu.ResumeLayout(false);
            this.TlStrpMenu.PerformLayout();
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel1.ResumeLayout(false);
            this.SpltPnlCntnrModuleAssessmentsHolder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpltPnlCntnrModuleAssessmentsHolder)).EndInit();
            this.SpltPnlCntnrModuleAssessmentsHolder.ResumeLayout(false);
            this.TlBrModulesPnl.ResumeLayout(false);
            this.TlBrModulesPnl.PerformLayout();
            this.AssessmentPnlToolBar.ResumeLayout(false);
            this.AssessmentPnlToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip TlStrpMenu;
        private System.Windows.Forms.SplitContainer SpltPnlCntnrModuleAssessmentsHolder;
        private System.Windows.Forms.Label LblModules;
        private System.Windows.Forms.Label LblUpComingAssessments;
        private System.Windows.Forms.TreeView TrVwModulesList;
        private System.Windows.Forms.TreeView TrVwUpcomingAssessments;
        private System.Windows.Forms.ToolStrip TlBrModulesPnl;
        private System.Windows.Forms.ToolStripButton TlStrpBtnAddModule;
        private System.Windows.Forms.ToolStripButton TlStrpBtnDeleteModule;
        private System.Windows.Forms.ToolStrip AssessmentPnlToolBar;
        private System.Windows.Forms.ToolStripButton TlStrpBtnDeleteAssessment;
        private System.Windows.Forms.OpenFileDialog OpnFlDlgModuleSelector;
        private System.Windows.Forms.ToolStripButton TlStrpBtnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TlStrpBtnLoadModules;
        private System.Windows.Forms.ToolStripButton TlStrpBtnViewAll;
        private System.Windows.Forms.ToolStripButton TlStrpBtnSort;
        private System.Windows.Forms.ToolStripButton TlStrpBtnMdlDeleteAssessment;
        private System.Windows.Forms.ToolStripButton TlStrpBtnSaveSettingsModules;
        private System.Windows.Forms.ToolStripButton TlStrpBtnLoadSettings;
    }
}

