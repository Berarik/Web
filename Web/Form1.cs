using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Adress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
               WeBrowser.Url=new Uri("http://"+Adress.Text.ToString());
        }

        private void WeBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel=true;
            WeBrowser.Url = new Uri(WeBrowser.StatusText);
        }

        private void AddressEnter_Click(object sender, EventArgs e)
        {
            WeBrowser.Url = new Uri("http://" + Adress.Text.ToString());
        }

        private void WebBrowserForm_Resize(object sender, EventArgs e)
        {
            WeBrowser.Size = new Size(ClientSize.Width - 10, ClientSize.Height - 10);
            WeBrowser.Update();
            AddressEnter.Location= new System.Drawing.Point(WeBrowser.Width-AddressEnter.Size.Width, 10);
            Adress.Size = new Size(WeBrowser.Width - AddressEnter.Size.Width-5 , AddressEnter.Height);
            AddressEnter.Update();
            Adress.Update();
        }
    }
}
