using System;
using System.Windows.Forms;

namespace ModNote
{
    public partial class PrgTrkBr : UserControl
    {
        /// <summary>
        /// Initiliaze control components
        /// </summary>
        public PrgTrkBr()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create eventhandler to handle the event of track bar value being changed and retrieve new value
        /// </summary>
        public EventHandler trackBarValueChanged;

        /// <summary>
        /// Create variables and properties to store trackbar data
        /// </summary>
        private int maximum = 100;
        private int minimum = 0;
        private int trackBarValue = 0;
        private bool moving = false;

        public int Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
            }
        }

        public int Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
            }
        }

        public int TrackBarValue
        {
            get
            {
                return trackBarValue;
            }
            set
            {
                trackBarValue = value;
                MoveThumb();
                if (trackBarValueChanged != null)
                {
                    trackBarValueChanged(this, EventArgs.Empty); //Create event with the trackbar as the sender and no event arguments
                }
            }
        }

        

        /// <summary>
        /// Procedure to update thumb buttons location and progress panels width
        /// </summary>
        private void MoveThumb()
        {
            int trackDistance = this.ClientSize.Width - btnThumb.Width;
            float fractionMoved = (float)(TrackBarValue - Minimum) /
                (float)(Maximum - Minimum); // 0 to 1
            btnThumb.Left = (int)(fractionMoved * (float)trackDistance);
            pbProgress.Width = (btnThumb.Right - btnThumb.Width);
        }

        /// <summary>
        /// On resizing the control set track panels width to the new size of the control
        /// </summary>
        private void ProgressTrackBar_Resize(object sender, EventArgs e)
        {
            pnlTrack.Width = this.ClientSize.Width;
        }

        /// <summary>
        /// On clicking anywhere on the control set moving variable to true and call procedure to update the trackbars values
        /// </summary>
        private void ProgressTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            ProgressTrackBar_MouseMove(sender, e);
        }

        /// <summary>
        /// Procedure to update the trackbars value when moving the mouse
        /// </summary>
        private void ProgressTrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                int value = Minimum + (int)(((float)e.X /
                    (float)(this.ClientSize.Width - btnThumb.Width)) *
                    (float)(Maximum - Minimum));
                if (value > Maximum)
                {
                    value = Maximum;
                }
                if (value < Minimum)
                {
                    value = Minimum;
                }
                this.TrackBarValue = value;
            }

        }

        /// <summary>
        /// When the mouseclick ends change moving to false so the trackbar value doesnt change anymore
        /// </summary>
        private void ProgressTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
    }
}
