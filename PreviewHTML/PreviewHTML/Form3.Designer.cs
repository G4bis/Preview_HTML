namespace PreviewHTML
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_css = new System.Windows.Forms.Label();
            this.txt_CSS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_css
            // 
            this.lbl_css.AutoSize = true;
            this.lbl_css.Location = new System.Drawing.Point(131, 22);
            this.lbl_css.Name = "lbl_css";
            this.lbl_css.Size = new System.Drawing.Size(134, 13);
            this.lbl_css.TabIndex = 0;
            this.lbl_css.Text = "Scrivi qui il tuo codice CSS";
            // 
            // txt_CSS
            // 
            this.txt_CSS.Location = new System.Drawing.Point(45, 81);
            this.txt_CSS.Name = "txt_CSS";
            this.txt_CSS.Size = new System.Drawing.Size(100, 96);
            this.txt_CSS.TabIndex = 1;
            this.txt_CSS.Text = "";
            this.txt_CSS.TextChanged += new System.EventHandler(this.txt_CSS_TextChanged_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 626);
            this.Controls.Add(this.txt_CSS);
            this.Controls.Add(this.lbl_css);
            this.Location = new System.Drawing.Point(1490, 160);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CSS Code";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_css;
        private System.Windows.Forms.RichTextBox txt_CSS;
    }
}