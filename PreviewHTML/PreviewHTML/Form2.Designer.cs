namespace PreviewHTML
{
    partial class Form2
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
            this.txt_HTML = new System.Windows.Forms.TextBox();
            this.lbl_html = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_HTML
            // 
            this.txt_HTML.Location = new System.Drawing.Point(45, 55);
            this.txt_HTML.Multiline = true;
            this.txt_HTML.Name = "txt_HTML";
            this.txt_HTML.Size = new System.Drawing.Size(324, 554);
            this.txt_HTML.TabIndex = 0;
            this.txt_HTML.TextChanged += new System.EventHandler(this.txt_HTML_TextChanged);
            // 
            // lbl_html
            // 
            this.lbl_html.AutoSize = true;
            this.lbl_html.Location = new System.Drawing.Point(131, 22);
            this.lbl_html.Name = "lbl_html";
            this.lbl_html.Size = new System.Drawing.Size(143, 13);
            this.lbl_html.TabIndex = 1;
            this.lbl_html.Text = "Scrivi qui il tuo codice HTML";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 626);
            this.Controls.Add(this.lbl_html);
            this.Controls.Add(this.txt_HTML);
            this.Location = new System.Drawing.Point(0, 173);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HTML Code";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HTML;
        private System.Windows.Forms.Label lbl_html;
    }
}