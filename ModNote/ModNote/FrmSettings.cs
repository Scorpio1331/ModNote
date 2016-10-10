using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmSettings : Form
    {
        
        /// <summary>
        /// Create Variables to reference parent form and store modules to be saved
        /// </summary>
        private FrmMain mainFrm;
        private List<string> savedModules;

        /// <summary>
        /// Initialize form and variables and create a reference to parent form
        /// </summary>
        /// <param name="mainFrm">Reference to parent form</param>
        public FrmSettings(FrmMain mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            savedModules = new List<string>();
        }

        /// <summary>
        /// On autoload modules checkbox checkstate change enable or disable CheckListBox of modules to corrospond
        /// </summary>
        private void ChkbxAutoLoadModules_Checked(object sender, EventArgs e)
        {
            ChkdLstbxAutoLoadModules.Enabled = ChkbxAutoLoadModules.Checked;
        }

        /// <summary>
        /// On clicking save button, change parent forms settings fields using their properties and return a dialogresult OK
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            mainFrm.SavedModules = savedModules;
            mainFrm.AutoLoadModules = ChkbxAutoLoadModules.Checked;
            this.DialogResult = DialogResult.OK; //Close form by return dialog result
        }

        /// <summary>
        /// On form load set values based on parent forms settings fields
        /// </summary>
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            ChkbxAutoLoadModules.Checked = mainFrm.AutoLoadModules; //Set AutoLoadModules checked to match parent forms value
            foreach (IModule module in mainFrm.Modules)
            {
                string moduleItem = string.Format("Module Title: {0}, Code: {1}", module.Title, module.Code);
                ChkdLstbxAutoLoadModules.Items.Add(moduleItem); //loop through parent form modules and add each to CheckListBox
                ChkdLstbxAutoLoadModules.SetItemChecked(ChkdLstbxAutoLoadModules.Items.IndexOf(moduleItem), true); //Set each item as checked by  default
            }
        }

        /// <summary>
        /// On checking/unchecking CheckListBox item, add or remove module from savedmodules list
        /// </summary>
        private void ChkdLstbxAutoLoadModules_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string checkedItem = ((string)ChkdLstbxAutoLoadModules.Items[e.Index]).Split(new string[] {"Code: "},StringSplitOptions.RemoveEmptyEntries)[1];
            IModule module = mainFrm.Modules.Find(item => item.Code == checkedItem); //Find module using code retrieved from splitting the items text
            if (e.NewValue == CheckState.Checked)
                savedModules.Add(module.Title + "..." + module.Code); //If items new value is checked, add module, if unchecked remove module.
            else
                savedModules.Remove(module.Title + "..." + module.Code);
        }
    }
}
