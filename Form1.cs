using System;
using System.Windows.Forms;

namespace ColrPickr
{
    public partial class frmApp : Form
    {

        ColorPickerClient cpc;
        public frmApp()
        {
            InitializeComponent();

            // Set the display of the label to false
            lblColor.Visible = false;
        }

        /*
         * 
         * Red button to change the color of the label to red.
         * Set the label text to "Red".
         * Set the display of the label to true.
         *
         */
        private void btnRed_Click(object sender, EventArgs e)
        {
            cpc = new ColorPickerClient(new Red(), lblColor);
            cpc.ColorText();
        }

        /*
         * 
         * Red button to change the color of the label to green.
         * Set the label text to "Green".
         * Set the display of the label to true.
         * 
         */
        private void btnGreen_Click(object sender, EventArgs e)
        {
            cpc = new ColorPickerClient(new Green(), lblColor);
            cpc.ColorText();
        }

        /*
         * 
         * Red button to change the color of the label to blue.
         * Set the label text to "Blue".
         * Set the display of the label to true.
         *
         */
        private void btnBlue_Click(object sender, EventArgs e)
        {
            cpc = new ColorPickerClient(new Blue(), lblColor);
            cpc.ColorText();

        }
    }
}
