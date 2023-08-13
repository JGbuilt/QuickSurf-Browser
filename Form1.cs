using System.Diagnostics;

namespace Untitled_Browser_thing_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnWebViewSourceChanged(object? sender,

  Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            textBox.Text = webView2.Source.ToString();
        }
        private void OnTextBoxAddressKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                webView2.Source = new Uri(textBox.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webView2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView2.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webView2.Reload();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TheMicrosoftFan/WebSurf/releases/tag/1.1");
        }
    }
}