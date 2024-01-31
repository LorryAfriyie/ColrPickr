using System.Drawing;
using System.Windows.Forms;

namespace ColrPickr
{
    // Inheriting from the IColorPickerStrategyBase Interface
    class Red : IColorPickerStrategyBase
    {
        /*
         * Changing the visibility of the text to true
         * Setting the text of the label to "Red".
         * Changing the color of the label to red.
         */
        public void ColorName(Label lblColor)
        {
            lblColor.Visible = true;
            lblColor.Text = "Red";
            lblColor.ForeColor = Color.Red;
        }
    }
}
