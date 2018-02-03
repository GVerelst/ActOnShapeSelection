using System.Windows.Forms;
using Visio = Microsoft.Office.Interop.Visio;

namespace ActOnShapeSelection
{
    public partial class ThisAddIn
    {
        bool _isAddingAShape = false;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.SelectionChanged += Application_SelectionChanged;
            Application.ShapeAdded += Application_ShapeAdded;
        }

        private void Application_ShapeAdded(Visio.Shape Shape) 
        {
            _isAddingAShape = true;
        }

        private void Application_SelectionChanged(Visio.Window Window)
        {
            if (!_isAddingAShape)
            {
                ActionsRibbon rib = Globals.Ribbons.ActionsRibbon;
                Visio.Selection selection = Window.Selection;
                foreach (dynamic item in selection)
                {
                    Visio.Shape shp = item as Visio.Shape;
                    if (shp != null)
                    {
                        shp.Characters.Text = "selected";
                        shp.CellsSRC[(short)Visio.VisSectionIndices.visSectionObject, 3, 0].FormulaU = $"THEMEGUARD(RGB({rib.Red}, {rib.Green}, {rib.Blue}))";
                    }
                }
            }
            _isAddingAShape = false;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
