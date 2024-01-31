using System.Windows.Forms;

namespace ColrPickr
{
    class ColorPickerClient
    {
        // Interface property
        IColorPickerStrategyBase cpsb { get; set; }

        // Get the label text from the chosen button from the Form1 class.
        private Label lblColor;

        // ColorPickerClient class constructor.
        public ColorPickerClient(IColorPickerStrategyBase cpsb, Label label)
        {
            this.cpsb = cpsb;
            lblColor = label;
        }


        public void ColorText()
        {
            cpsb.ColorName(lblColor);
        }
    }
}
