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
///
namespace PreviewHTML
{
    public partial class Form3 : Form
    {
        /// <summary>
        /// percorso di destinazione del file css
        /// </summary>
        string perc = @"C:\HTMLpreviewer\cssdoc.css";
       /// <summary>
       /// istanza di un oggetto di tipo form 1
       /// </summary>
        Form1 f = new Form1();
     
        /// <summary>
        /// costruttore del form 3 , imposta le coordinate di tutti gli elementi presenti , e anche il colore del form
        /// </summary>
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
        

        /// <summary>
        /// Passa il form 1 come paramentro,per richiamare in seguito un metodo get
        /// </summary>
        /// <param name="f1">f1 è un parametro di tipo Form1 </param>
        public void setf1(Form1 f1)
        {
            f = f1;
        }
        /// <summary>
        /// Al caricamento del form3 imposta un'icona e carica l'ultimo progetto html se già esistente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {

            this.Icon = new Icon(@"Resources\css3.ico");
            if (new FileInfo(perc).Length != 0)
            {
                txt_CSS.Text = File.ReadAllText(perc);

            }
           
        }
        /// <summary>
        /// Metodo per salvare su un file il codice css
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    ///</doc>
}
