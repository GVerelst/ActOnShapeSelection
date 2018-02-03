using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace ActOnShapeSelection
{
    public partial class ActionsRibbon
    {
        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }

        private void ActionsRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void btnRed_Click(object sender, RibbonControlEventArgs e)
        {
            Red = (byte)(255 - Red);
        }

        private void btnGreen_Click(object sender, RibbonControlEventArgs e)
        {
            Green = (byte)(255 - Green);
        }

        private void btnBlue_Click(object sender, RibbonControlEventArgs e)
        {
            Blue = (byte)(255 - Blue);
        }

        private void group1_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            ColorDialog dlg = new ColorDialog { Color = Color.FromArgb(Red, Green, Blue) };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Red = dlg.Color.R;
                Green = dlg.Color.G;
                Blue = dlg.Color.B;
            }
        }
    }
}
