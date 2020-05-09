namespace MOVA2020.forms
{
    partial class sähkoposti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbosoite = new System.Windows.Forms.TextBox();
            this.tbsalasana = new System.Windows.Forms.TextBox();
            this.btkirjaudu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sähköposti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana";
            // 
            // tbosoite
            // 
            this.tbosoite.Location = new System.Drawing.Point(131, 25);
            this.tbosoite.Name = "tbosoite";
            this.tbosoite.Size = new System.Drawing.Size(307, 26);
            this.tbosoite.TabIndex = 0;
            // 
            // tbsalasana
            // 
            this.tbsalasana.Location = new System.Drawing.Point(131, 62);
            this.tbsalasana.Name = "tbsalasana";
            this.tbsalasana.PasswordChar = '*';
            this.tbsalasana.Size = new System.Drawing.Size(307, 26);
            this.tbsalasana.TabIndex = 1;
            // 
            // btkirjaudu
            // 
            this.btkirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btkirjaudu.Location = new System.Drawing.Point(145, 94);
            this.btkirjaudu.Name = "btkirjaudu";
            this.btkirjaudu.Size = new System.Drawing.Size(198, 43);
            this.btkirjaudu.TabIndex = 2;
            this.btkirjaudu.Text = "Kirjaudu";
            this.btkirjaudu.UseVisualStyleBackColor = true;
            this.btkirjaudu.Click += new System.EventHandler(this.btkirjaudu_Click);
            // 
            // sähkoposti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 148);
            this.Controls.Add(this.btkirjaudu);
            this.Controls.Add(this.tbsalasana);
            this.Controls.Add(this.tbosoite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sähkoposti";
            this.Text = "GMAIL kirjautuminen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbosoite;
        private System.Windows.Forms.TextBox tbsalasana;
        private System.Windows.Forms.Button btkirjaudu;
    }
}