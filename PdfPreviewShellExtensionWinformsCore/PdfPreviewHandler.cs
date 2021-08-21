using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfPreviewShellExtensionWinformsCore
{
    [COMServerAssociation(AssociationType.ClassOfExtension, ".pdf")]
    [DisplayName("Pdf Preview Handler")]
    [ComVisible(true)]
    class PdfPreviewHandler : SharpPreviewHandler
    {
        protected override PreviewHandlerControl DoPreview()
        {
            
            var c = new SimplePreviewHanderUserControl();
            
            c.DoPreview(SelectedFilePath);
            return c;
        }
    }
}
