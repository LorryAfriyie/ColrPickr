using System.Drawing;
using System.Windows.Forms;

namespace ColrPickr
{
    class Yellow : IColorPickerStrategyBase
    {
        public void ColorName(Label lblColor)
        {
            lblColor.Visible = true;
            lblColor.Text = "Yellow";
            lblColor.ForeColor = Color.Yellow;
        }
    }
}
