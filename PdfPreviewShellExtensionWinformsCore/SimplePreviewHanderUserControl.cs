using SharpShell.SharpPreviewHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfPreviewShellExtensionWinformsCore
{
    public partial class SimplePreviewHanderUserControl : PreviewHandlerControl
    {
        public SimplePreviewHanderUserControl()
        {
            InitializeComponent();
        }

        internal void DoPreview(string selectedFilePath)
        {
            Controls.Add(new Label() { Text = selectedFilePath });
        }
    }
}
