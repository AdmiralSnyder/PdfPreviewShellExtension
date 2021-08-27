using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.SharpPreviewHandler;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace PdfPreviewShellExtensionLib
{
    public partial class SimplePreviewHanderUserControl : PreviewHandlerControl
    {
        public SimplePreviewHanderUserControl()
        {
            InitializeComponent();
        }

        string SelectedFilePath;
        internal void DoPreview(string selectedFilePath)
        {
            SelectedFilePath = selectedFilePath;
            label1.Text = selectedFilePath;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // TODO delete temp files when unloading extension
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "PdfPreviewHandler");
            
            Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, Guid.NewGuid().ToString());

            Directory.CreateDirectory(path);
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder: path);

            await webView21.EnsureCoreWebView2Async(env);//.ConfigureAwait(true);
            if (File.Exists(SelectedFilePath))
            {
                webView21.Source = new Uri(SelectedFilePath);
            }
        }
    }
}
