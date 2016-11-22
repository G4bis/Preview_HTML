﻿using System;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            string path =@"C:\HTMLpreviewer";
            InitializeComponent();
            this.Width = ((1080*Screen.PrimaryScreen.WorkingArea.Width)/1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            webBrowser1.Width = ((1040 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            webBrowser1.Height = ((535 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            webBrowser1.Location = new Point(((12 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((100 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button1.Location = new Point(((270 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((48 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button2.Location = new Point(((591 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((48 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            this.BackColor = Color.Gray;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(@"C:\HTMLpreviewer\htmldoc.html");
                File.Create(@"C:\HTMLpreviewer\cssdoc.css");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.setf1(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        public WebBrowser getbw()
        {
            return webBrowser1;
        }
       
      

    
    }
}
