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
    public partial class Form2 : Form
    {
       
        /// <summary>
        /// istanza di un oggetto di tipo form 1
        /// </summary>
        Form1 f = new Form1();
        /// <summary>
        /// percorso di destinazione del file html
        /// </summary>
        string perc = @"C:\HTMLpreviewer\htmldoc.html";
        /// <summary>
        /// costruttore del form 2 , imposta le coordinate di tutti gli elementi presenti , e anche il colore del form
        /// </summary>
      
        
        public Form2()
        {
            InitializeComponent();
            this.Width = ((430 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            this.Height = ((720 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            txt_HTML.Width = ((392 * Screen.PrimaryScreen.WorkingArea.Width) / 1920);
            txt_HTML.Height = ((598 * Screen.PrimaryScreen.WorkingArea.Height) / 1080);
            this.Location = new Point(0,((182 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            txt_HTML.Location = new Point(((8 * Screen.PrimaryScreen.WorkingArea.Width) / 1920), ((55 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            lbl_html.Location = new Point(((this.Width - lbl_html.Width) / 2), ((22 * Screen.PrimaryScreen.WorkingArea.Height) / 1080));
            this.BackColor = Color.DarkCyan;
        }
        /// <summary>
        /// imposta oltre all'icona del form , nella textbox del codice di riferimento ad un file di stile css se il file è vuoto, altrimenti carica l'ultimo file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"Resources\HTML5_Logo_512.ico");
            if (new FileInfo(perc).Length == 0)
            {
                txt_HTML.Text = @" <head><link rel='stylesheet' type='text/css' href='C:\HTMLpreviewer\cssdoc.css'></head>";
            }
            else
            {
                txt_HTML.Text = File.ReadAllText(perc);

            }
            
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
        /// Metodo per salvare su un file il codice html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_HTML_TextChanged_1(object sender, EventArgs e)
        {
            f.getbw().DocumentText = txt_HTML.Text;
            StreamWriter sw = new StreamWriter(perc, false);
            sw.Close();
            sw = new StreamWriter(perc, true);
            sw.Write(txt_HTML.Text);
            sw.Close();
        }
      
    }
    ///</doc>
}
