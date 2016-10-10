namespace ModNote
{
    partial class FrmSettings
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
            this.ChkdLstbxAutoLoadModules = new System.Windows.Forms.CheckedListBox();
            this.ChkbxAutoLoadModules = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkdLstbxAutoLoadModules
            // 
            this.ChkdLstbxAutoLoadModules.Enabled = false;
            this.ChkdLstbxAutoLoadModules.FormattingEnabled = true;
            this.ChkdLstbxAutoLoadModules.HorizontalScrollbar = true;
            this.ChkdLstbxAutoLoadModules.Location = new System.Drawing.Point(3, 25);
            this.ChkdLstbxAutoLoadModules.Name = "ChkdLstbxAutoLoadModules";
            this.ChkdLstbxAutoLoadModules.Size = new System.Drawing.Size(464, 94);
            this.ChkdLstbxAutoLoadModules.Sorted = true;
            this.ChkdLstbxAutoLoadModules.TabIndex = 1;
            this.ChkdLstbxAutoLoadModules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkdLstbxAutoLoadModules_ItemCheck);
            // 
            // ChkbxAutoLoadModules
            // 
            this.ChkbxAutoLoadModules.AutoSize = true;
            this.ChkbxAutoLoadModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkbxAutoLoadModules.Location = new System.Drawing.Point(6, 3);
            this.ChkbxAutoLoadModules.Name = "ChkbxAutoLoadModules";
            this.ChkbxAutoLoadModules.Size = new System.Drawing.Size(151, 22);
            this.ChkbxAutoLoadModules.TabIndex = 2;
            this.ChkbxAutoLoadModules.Text = "Auto-load Modules";
            this.ChkbxAutoLoadModules.UseVisualStyleBackColor = true;
            this.ChkbxAutoLoadModules.CheckedChanged += new System.EventHandler(this.ChkbxAutoLoadModules_Checked);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(39, 125);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(157, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(256, 125);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(157, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 155);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ChkbxAutoLoadModules);
            this.Controls.Add(this.ChkdLstbxAutoLoadModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChkdLstbxAutoLoadModules;
        private System.Windows.Forms.CheckBox ChkbxAutoLoadModules;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}