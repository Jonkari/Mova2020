﻿namespace MOVA2020.forms
{
    partial class Varausasiakastiedot
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
            this.CBVaraus = new System.Windows.Forms.ComboBox();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBVaraus
            // 
            this.CBVaraus.FormattingEnabled = true;
            this.CBVaraus.Location = new System.Drawing.Point(128, 15);
            this.CBVaraus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBVaraus.Name = "CBVaraus";
            this.CBVaraus.Size = new System.Drawing.Size(248, 28);
            this.CBVaraus.TabIndex = 0;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Location = new System.Drawing.Point(13, 18);
            this.lblVaraus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(62, 20);
            this.lblVaraus.TabIndex = 1;
            this.lblVaraus.Text = "Varaus";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Varausasiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.CBVaraus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Varausasiakastiedot";
            this.Text = "Varaajan tiedot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBVaraus;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Button button1;
    }
}