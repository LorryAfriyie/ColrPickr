using System.Drawing;
using System.Windows.Forms;

namespace ColrPickr
{
    // Inheriting from the IColorPickerStrategyBase Interface
    class Blue : IColorPickerStrategyBase
    {
        /*
         * Changing the visibility of the text to true
         * Setting the text of the label to "Blue".
         * Changing the color of the label to blue.
         */
        public void ColorName(Label lblColor)
        {
            lblColor.Visible = true;
            lblColor.Text = "Blue";
            lblColor.ForeColor = Color.Blue;

        }
    }
}
