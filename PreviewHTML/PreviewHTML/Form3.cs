using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PreviewHTML
{
    public partial class Form3 : Form
    {
   
        string perc = @"C:\HTMLpreviewer\cssdoc.css";
        
        public Form3()
        {
            InitializeComponent();
            this.Width = ((430 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            txt_CSS.Width = ((324 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            txt_CSS.Height = ((554 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            this.Location = new Point(((1490 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((173 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            txt_CSS.Location = new Point(((45 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((55 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            lbl_css.Location = new Point(((this.Width - lbl_css.Width) / 2), ((22 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
        }

        private void txt_CSS_TextChanged(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(perc, false);
            sw.Close();
            sw = new StreamWriter(perc, true);
            sw.Write(txt_CSS.Text);
            sw.Close();
        }

     

       
    }
}
