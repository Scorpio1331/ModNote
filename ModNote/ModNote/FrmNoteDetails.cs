using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ModNote
{
    public partial class FrmNoteDetails : Form
    {
        /// <summary>
        /// Create variable and property to store the note
        /// </summary>
        private INote note;
        public INote Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        /// <summary>
        /// Initialize form with optional note parameter
        /// </summary>
        /// <param name="note">Optional note to edit</param>
        public FrmNoteDetails(INote note = null)
        {
            InitializeComponent();
            Debug.WriteLine("\n******- FrmNoteDetails(INote) Initialized -******");
            if (note != null)
            {
                Debug.WriteLine("Branch 1:Note is not null so create reference");
                Note = note;
            }
            else
            {
                Debug.WriteLine("Branch 2: Note is null so create new note");
                Note = new Note("", ""); //If note is null create a new note
            }
            Debug.WriteLine(" ******-FrmNoteDetails function ending-******\n");

        }

        /// <summary>
        /// On form load load note information into textboxes and add images and links to form
        /// </summary>
        private void FrmNoteDetails_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("\n******- FrmNoteDetails_Load(object, EventArgs) called -******");
            Debug.Write("Note text: " + Note.Text);
            Debug.WriteLine("Note Title: " + Note.Title);
            TxtbxText.Text = Note.Text;
            TxtbxTitle.Text = Note.Title;
            if (Note.Images.Count > 0)
            {
                Debug.WriteLine("Branch 1: Notes images is not empty so add images");
                foreach (string image in Note.Images) //loop through notes images and create a picturebox for each
                {
                    Debug.WriteLine("Creating new picturebox for image");
                    PictureBox newImage = new PictureBox();
                    newImage.Size = new System.Drawing.Size(FlwLytPnlImages.Width / 3, FlwLytPnlImages.Height / 2);
                    newImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    newImage.ImageLocation = image.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[0]; //Split image location and image name from image text
                    newImage.Name = image.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[1];
                    newImage.ContextMenuStrip = CntxtMnuStrpImages;
                    newImage.MouseClick += ImageClicked; //Add context menu strip and mouseclick event to picturebox, then add it to flowlayoutpanel
                    Debug.WriteLine("Adding new picturebox " +newImage.Name + " to panel");
                    FlwLytPnlImages.Controls.Add(newImage);
                    
                }
            }
            if (Note.Links.Count > 0)
            {
                Debug.WriteLine("Branch 1: Notes Links is not empty so add links");
                foreach (string link in Note.Links) //loop through notes links and create a Linklabel for each
                {
                    Debug.WriteLine("Creating new linklabel for link");
                    LinkLabel newLinkLabel = new LinkLabel();
                    LinkLabel.Link newLink = new LinkLabel.Link();
                    newLink.LinkData = link.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[0];
                    newLink.Name = link.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[1];//Split Link url and link name from link text
                    newLinkLabel.Text = newLink.Name;
                    newLinkLabel.Links.Add(newLink);
                    newLinkLabel.AutoSize = true;
                    newLinkLabel.LinkClicked += LabelClicked;
                    newLinkLabel.ContextMenuStrip = CntxtMnuStrpLinks; //Add context menu strip and mouseclick event to Linklabel, then add it to flowlayoutpanel
                    Debug.WriteLine("Adding new linklabel " + newLinkLabel.Name + " to panel");
                    FlwLytPnlLinks.Controls.Add(newLinkLabel);
                }
            }
            Debug.WriteLine(" ******-FrmNoteDetails_Load function ending-******\n");
        }
        /// <summary>
        /// On clicking a LinkLabel open the link in web/file browser
        /// </summary>
        private void LabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return; //If mouseclick was right click exit out of procedure
            LinkLabel label = sender as LinkLabel; 
            label.Links[label.Links.IndexOf(e.Link)].Visited = true; //Get linkLabel that was clicked and set visited status to true            
            string target = e.Link.LinkData as string; //Get link url from linkdata
            try
            {
                System.Diagnostics.Process.Start(target); //Start default process to open link url
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// On clicking Add link create new Linklabel then open form to get link details,
        /// and add the new linklabel to the flowlayout panel
        /// </summary>
        private void BtnAddLink_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\n******- BtnAddLink_Click(object,EventArgs) called -******");
            LinkLabel newLinkLabel = new LinkLabel();
            LinkLabel.Link newLink = new LinkLabel.Link();
            Debug.WriteLine("Creating new Link form and showing to user");
            FrmLinkImagesDetails linkDetails = new FrmLinkImagesDetails(false); //Create new form to take Link details and initiliaze for a link
            linkDetails.ShowDialog();
            if (linkDetails.DialogResult == DialogResult.Cancel)
            {
                Debug.WriteLine("Branch 1: User clicked cancel button, exiting procedure");
                Debug.WriteLine(" ******-BtnAddLink_Click function ending-******\n");
                return;
            }
            newLink.LinkData = linkDetails.Link;
            newLink.Name = linkDetails.Title;
            newLinkLabel.Text = newLink.Name;
            newLinkLabel.Links.Add(newLink); //Set link data
            newLinkLabel.AutoSize = true;
            newLinkLabel.LinkClicked += LabelClicked;
            newLinkLabel.ContextMenuStrip = CntxtMnuStrpLinks; //Add context menu strip and mouseclick event to Linklabel, then add it to flowlayoutpanel
            Debug.WriteLine("Adding new link " + newLinkLabel.Name + " to notes link list");
            Note.addLink(linkDetails.Title,newLink.LinkData.ToString());
            Debug.WriteLine("Adding new linklabel " + newLinkLabel.Name + " to panel");
            FlwLytPnlLinks.Controls.Add(newLinkLabel); //Add new linklabel to flowlayout panel
            Debug.WriteLine(" ******-BtnAddLink_Click function ending-******\n");
        }

        /// <summary>
        /// On clicking Save button check if necessary fields are filled and then return dialogresult ok
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\n******- BtnSave_Click(object,EventArgs) called -******");
            if (!String.IsNullOrWhiteSpace(TxtbxTitle.Text)) //If note has a title set note title and text
            {
                Debug.WriteLine("Branch 1: Note title is not null, empty or white space");
                Debug.WriteLine("Notes title: "+TxtbxTitle.Text);
                Note.Title = TxtbxTitle.Text;
                Note.Text = TxtbxText.Text;
                Debug.WriteLine(" ******-BtnSave_Click function ending-******\n");
                this.DialogResult = DialogResult.OK; //Close form by returning dialog result ok
            } else
            {
                Debug.WriteLine("Branch 2: Note title is null, empty or white space");
                MessageBox.Show("Please enter a Title for the note"); //Tell user to give the note a title
            }
        }

        /// <summary>
        /// On clicking Add image create new PictureBox then open form to get image details,
        /// and add the new PictureBox to the flowlayout panel
        /// </summary>
        private void AddImage_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\n******- AddImage_Click(object,EventArgs) called -******");
            PictureBox newImage = new PictureBox();
            Debug.WriteLine("Creating new image form and showing to user");
            FrmLinkImagesDetails imageDetails = new FrmLinkImagesDetails(true); //Create new form to take image details and initiliaze for a image
            imageDetails.ShowDialog();
            if (imageDetails.DialogResult == DialogResult.Cancel) {
                Debug.WriteLine("Branch 1: User clicked cancel button, exiting procedure");
                Debug.WriteLine(" ******-AddImage_Click function ending-******\n");
                return;
            }
            newImage.Size = new System.Drawing.Size(FlwLytPnlImages.Width / 3, FlwLytPnlImages.Height / 2);
            newImage.SizeMode = PictureBoxSizeMode.StretchImage;
            newImage.ImageLocation = imageDetails.FilePath;
            newImage.Name = imageDetails.Caption;
            Debug.WriteLine("Adding new image " + newImage.Name + " to notes image list");
            Note.addImage(imageDetails.FilePath, imageDetails.Caption); //Add image to notes image list
            newImage.MouseClick += ImageClicked;             
            newImage.ContextMenuStrip = CntxtMnuStrpImages;//Add context menu strip and mouseclick event to picturebox, then add it to flowlayoutpanel
            Debug.WriteLine("Adding new picturebox " + newImage.Name + " to panel");
            FlwLytPnlImages.Controls.Add(newImage);
            Debug.WriteLine(" ******-AddImage_Click function ending-******\n");
        }
        /// <summary>
        /// On clicking Delete image button get buttons contextmenustrips owner and remove the picturebox from flowlayoutpanel and remove the
        /// image from the notes list
        /// </summary>
        private void TlStrpMnuItmDeleteImage_Click(object sender, EventArgs e)
        {
            ToolStripItem deleteBtn = sender as ToolStripItem;
            if (deleteBtn != null)
            {                
                ContextMenuStrip owner = deleteBtn.Owner as ContextMenuStrip; //Get the contextmenustrip that owns this toolstripitem
                if (owner != null)
                {
                    PictureBox image = owner.SourceControl as PictureBox; //Get picturebox that was displaying the context menu
                    FlwLytPnlImages.Controls.Remove(image);
                    Note.Images.Remove(image.ImageLocation + "..." + image.Name); //Remove picturebox from flowlayoutpanel and remove image from notes list
                }
            }
        }
        /// <summary>
        /// On clicking Delete Link button get buttons contextmenustrips owner and remove the LinkLabel from flowlayoutpanel and remove the
        /// Link from the notes list
        /// </summary>
        private void TlStrpMnuItmDeleteLink_Click(object sender, EventArgs e)
        {
            ToolStripItem deleteBtn = sender as ToolStripItem;
            if (deleteBtn != null)
            {
                ContextMenuStrip owner = deleteBtn.Owner as ContextMenuStrip; //Get the contextmenustrip that owns this toolstripitem
                if (owner != null)
                {
                    LinkLabel link = owner.SourceControl as LinkLabel;// Get LinkLabel that was displaying the context menu
                    FlwLytPnlLinks.Controls.Remove(link);
                    Note.Links.Remove(link.Links[0].LinkData + "..." + link.Text);//Remove LinkLabel from flowlayoutpanel and remove Link from notes list
                }
            }
        }
        /// <summary>
        /// On clicking a images picturebox open form and pass picturebox as initializing parameter to open the image
        /// in its default size
        /// </summary>
        private void ImageClicked(object sender, MouseEventArgs e)
        {
            PictureBox clickedImage = sender as PictureBox;
            FrmViewImage imageViewer = new FrmViewImage(clickedImage);//Initialize form to view image with clicked picturebox
            imageViewer.Show();
        }
    }
}
