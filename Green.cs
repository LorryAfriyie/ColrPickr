using System.Drawing;
using System.Windows.Forms;

namespace ColrPickr
{
    // Inheriting from the IColorPickerStrategyBase Interface
    class Green : IColorPickerStrategyBase
    {
        /*
         * Changing the visibility of the text to true
         * Setting the text of the label to "Green".
         * Changing the color of the label to green.
         */

        public void ColorName(Label lblColor)
        {
            lblColor.Visible = true;
            lblColor.Text = "Green";
            lblColor.ForeColor = Color.Green;
        }
    }
}
