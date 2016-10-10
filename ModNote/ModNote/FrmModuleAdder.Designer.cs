namespace ModNote
{
    partial class FrmModuleAdder
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
            this.BtnAddModuleManual = new System.Windows.Forms.Button();
            this.BtnImportModuleFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddModuleManual
            // 
            this.BtnAddModuleManual.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnAddModuleManual.Location = new System.Drawing.Point(7, 12);
            this.BtnAddModuleManual.Name = "BtnAddModuleManual";
            this.BtnAddModuleManual.Size = new System.Drawing.Size(144, 23);
            this.BtnAddModuleManual.TabIndex = 0;
            this.BtnAddModuleManual.Text = "Manually Add Module";
            this.BtnAddModuleManual.UseVisualStyleBackColor = true;
            // 
            // BtnImportModuleFile
            // 
            this.BtnImportModuleFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnImportModuleFile.Location = new System.Drawing.Point(154, 12);
            this.BtnImportModuleFile.Name = "BtnImportModuleFile";
            this.BtnImportModuleFile.Size = new System.Drawing.Size(144, 23);
            this.BtnImportModuleFile.TabIndex = 1;
            this.BtnImportModuleFile.Text = "Import Module file";
            this.BtnImportModuleFile.UseVisualStyleBackColor = true;
            // 
            // FrmModuleAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 43);
            this.Controls.Add(this.BtnImportModuleFile);
            this.Controls.Add(this.BtnAddModuleManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModuleAdder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Module";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAddModuleManual;
        private System.Windows.Forms.Button BtnImportModuleFile;
    }
}