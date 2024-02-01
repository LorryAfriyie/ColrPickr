using System.Drawing;
using System.Windows.Forms;

namespace ColrPickr
{
    class Purple : IColorPickerStrategyBase
    {
        public void ColorName(Label lblColor)
        {
            lblColor.Visible = true;
            lblColor.Text = "Purple";
            lblColor.ForeColor = Color.Purple;
        }
    }
}
