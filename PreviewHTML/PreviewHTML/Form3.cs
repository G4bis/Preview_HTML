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
       
        Form1 f = new Form1();
     

        public Form3()
        {
            InitializeComponent();
            this.Width = ((430 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            txt_CSS.Width = ((392 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            txt_CSS.Height = ((598 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            this.Location = new Point(((1490 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((182 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            txt_CSS.Location = new Point(((8 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((55 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            lbl_css.Location = new Point(((this.Width - lbl_css.Width) / 2), ((22 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            this.BackColor = Color.DarkCyan;
        }

       
        public void setf1(Form1 f1)
        {
            f = f1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            this.Icon = new Icon(@"Resources\css3.ico");
            if (new FileInfo(perc).Length != 0)
            {
                txt_CSS.Text = File.ReadAllText(perc);

            }
           
        }

        private void txt_CSS_TextChanged_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\HTMLpreviewer\htmldoc.html");
            f.getbw().DocumentText = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(perc, false);
            sw.Close();
            sw = new StreamWriter(perc, true);
            sw.Write(txt_CSS.Text);
            sw.Close();
        }

     

       
    }
}
