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

namespace PdfPreviewShellExtensionLib
{
    public partial class SimplePreviewHanderUserControl : PreviewHandlerControl
    {
        public SimplePreviewHanderUserControl()
        {
            InitializeComponent();
        }

        internal void DoPreview(string selectedFilePath)
        {
            System.Windows.Forms.MessageBox.Show("Peng");
            Controls.Add(new Label() { Text = selectedFilePath });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder: @"c:\webviewTemp");

            await webView21.EnsureCoreWebView2Async(env);//.ConfigureAwait(true);
            webView21.Source = new Uri("http://google.com");
        }
    }
}
