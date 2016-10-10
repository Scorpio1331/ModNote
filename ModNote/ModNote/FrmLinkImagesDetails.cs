using System;
using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmLinkImagesDetails : Form
    {

        /// <summary>
        /// Create variables and properties to store link/image values
        /// </summary>
        private string link;
        private string title;
        string filePath;
        string caption;
        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
            }
        }

        public string Caption
        {
            get
            {
                return caption;
            }

            set
            {
                caption = value;
            }
        }

        /// <summary>
        /// Initialize form and set panels visibility based on what is being created
        /// </summary>
        /// <param name="image">Whether an Image is being added or a Link</param>
        public FrmLinkImagesDetails(bool image)
        {
            InitializeComponent();
            if (image == false)//If Link is being added 
            {
                Link = "";
                Title = "";
                PnlImage.Visible = false; //Set image panel visibility to false and set Link panel visibility to true
                PnlLink.Visible = true;
            } else //Else a Image is being added
            {
                FilePath = "";
                Caption = "";
                PnlImage.Visible = true;//Set Link panel visibility to false and set Image panel visibility to true
                PnlLink.Visible = false;
            }

        }        

        /// <summary>
        /// On clicking Save check if all necessary fields have been filled out and then return dialog result ok
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (PnlImage.Visible == false)
            {
                if (string.IsNullOrWhiteSpace(TxtbxTitle.Text)) //If adding a link and title is textbox is empty tell user 
                {
                    MessageBox.Show("Please enter a Link Title");

                }
                else if (string.IsNullOrWhiteSpace(TxtbxURL.Text)) //If URl textbox is empty tell user
                {
                    MessageBox.Show("Please enter a Link URL");
                }
                else
                {
                    Link = TxtbxURL.Text;
                    Title = TxtbxTitle.Text;
                    this.DialogResult = DialogResult.OK; //Close form by returning dialogresult ok
                }
            } else
            {
                if (string.IsNullOrWhiteSpace(TxtbxFilePath.Text))//If adding image and filepath textbox is empty tell user
                {
                    MessageBox.Show("Please enter a File Path");

                }
                else if (string.IsNullOrWhiteSpace(TxtbxCaption.Text)) //If caption textbox is empty tell user
                {
                    MessageBox.Show("Please enter a Image Caption");
                }
                else
                {
                    FilePath = TxtbxFilePath.Text;
                    Caption = TxtbxCaption.Text;
                    this.DialogResult = DialogResult.OK;//Close form by returning dialogresult ok
                }
            }
        }        
        /// <summary>
        /// On clicking File explorer button open Open file dialog and set filepath to filename
        /// </summary>
        private void BtnFileExplorer_Click(object sender, EventArgs e)
        {
            OpnFlDlgFindImage.ShowDialog();
            string fileName = OpnFlDlgFindImage.FileName; //Get filename
            if (!string.IsNullOrWhiteSpace(fileName) && System.IO.File.Exists(fileName)) //If file exists set filepath and textbox to filename
            {
                FilePath = fileName;
                TxtbxFilePath.Text = fileName;
            }
            else //If file doesnt exist then tell user to try again
                MessageBox.Show("Please select a image file");
        }
    }
}
