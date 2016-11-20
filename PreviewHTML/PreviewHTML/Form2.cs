using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreviewHTML
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
            this.Width = ((430 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            txt_HTML.Width = ((324 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            txt_HTML.Height = ((554 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            this.Location = new Point(0,((173 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            txt_HTML.Location = new Point(((45 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((55 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            lbl_html.Location = new Point(((this.Width - lbl_html.Width) / 2), ((22 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            txt_HTML.Text = "<HTML>\r\n</HTML>"; 
        }
    }
}
