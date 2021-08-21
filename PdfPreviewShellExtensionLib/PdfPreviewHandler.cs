using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfPreviewShellExtensionLib
{
    [COMServerAssociation(AssociationType.FileExtension, ".pdf")]
    [DisplayName("Pdf Preview Handler")]
    [ComVisible(true)]
    [PreviewHandler()]
    public class PdfPreviewHandler : SharpPreviewHandler
    {
        protected override PreviewHandlerControl DoPreview()
        {
            System.Windows.Forms.MessageBox.Show("Hello");
            
            var c = new SimplePreviewHanderUserControl();
            
            c.DoPreview(SelectedFilePath);
            return c;
        }
    }
}
