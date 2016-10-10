using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmViewImage : Form
    {
        /// <summary>
        /// Initialize form with chosen image
        /// </summary>
        /// <param name="image">Clicked image to be shown</param>
        public FrmViewImage(PictureBox image)
        {
            InitializeComponent();
            if (image != null) //If image is not null set picturebox to contain image and set size of form to image size
            {
                PctrbxImage.ImageLocation = image.ImageLocation;
                PctrbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PctrbxImage.Load();
                this.Size = PctrbxImage.Image.Size;
                this.Text = image.Name;
            }
        }
    }
}
