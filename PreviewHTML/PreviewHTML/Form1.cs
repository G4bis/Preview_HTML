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

///<?xml version="1.0"?>
///<doc>
///<assembly>
///<name>PreviewHTML</name>
///</assembly>

namespace PreviewHTML
{
    public partial class Form1 : Form
    {
     /// <summary>
        /// costruttore del form 1 , imposta le coordinate di tutti gli elementi presenti , il colore del form e crea anche la cartella di destinazione dei file html e css
     /// </summary>
  
        public Form1()
        {
            string path =@"C:\HTMLpreviewer";
            InitializeComponent();
            this.Width = ((1080*Screen.PrimaryScreen.WorkingArea.Width)/1920);
            this.Height = ((721 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            webBrowser1.Width = ((1038 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            webBrowser1.Height = ((525 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            webBrowser1.Location = new Point(((10 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((100 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button1.Location = new Point(((270 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((12 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button2.Location = new Point(((591 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((12 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button3.Location= new Point(((270 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((48 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            button4.Location = new Point(((591 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((48 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            this.BackColor = Color.DarkCyan;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(@"C:\HTMLpreviewer\htmldoc.html").Close();
                File.Create(@"C:\HTMLpreviewer\cssdoc.css").Close();
            }
        }
        /// <summary>
        /// Bottone per mostrare il secondo form , dove editare il codice html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            f2.setf1(this);
            f2.Show();
           
            
        }
        /// <summary>
        /// Bottone per mostrare il terzo form , dove editare codice css
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.setf1(this);
            f3.Show();
        }
        /// <summary>
        /// metodo dove si ritorna l'oggetto di tipo WebBrowser
        /// </summary>
        /// <returns></returns>
        public WebBrowser getbw()
        {
            return webBrowser1;
        }
        /// <summary>
        /// bottone che dimostra l'avvenuto salvataggio del file html , e il relativo percorso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Il file html è stato salvato,lo troverai al percorso C:\HTMLpreviewer\htmldoc.html");
        }
        /// <summary>
        /// bottone che dimostra l'avvenuto salvataggio del file css , e il relativo percorso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Il file css è stato salvato,lo troverai al percorso C:\HTMLpreviewer\cssdoc.css");
        }
       
      

    
    }
    ///</doc>
}
