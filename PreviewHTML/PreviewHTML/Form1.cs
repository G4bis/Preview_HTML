﻿using System;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Width = ((1080*Screen.PrimaryScreen.WorkingArea.Width)/1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            this.BackColor = Color.Gray;
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
       
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "<html>dgg </html>";
        }

    
    }
}
