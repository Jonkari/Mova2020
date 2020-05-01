﻿namespace MOVA2020.forms
{
    partial class Varauksentiedot
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
            this.lblVaraus = new System.Windows.Forms.Label();
            this.calVaraus = new System.Windows.Forms.MonthCalendar();
            this.lblVarattupvm = new System.Windows.Forms.Label();
            this.dtpVarattupvm = new System.Windows.Forms.DateTimePicker();
            this.btnMokintiedot = new System.Windows.Forms.Button();
            this.btnAsiakkaantiedot = new System.Windows.Forms.Button();
            this.tbAsiakasnimi = new System.Windows.Forms.TextBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblAsiakasnimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVaraus.Location = new System.Drawing.Point(24, 248);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(53, 17);
            this.lblVaraus.TabIndex = 4;
            this.lblVaraus.Text = "Varaus";
            // 
            // calVaraus
            // 
            this.calVaraus.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calVaraus.Enabled = false;
            this.calVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calVaraus.Location = new System.Drawing.Point(27, 270);
            this.calVaraus.MaxSelectionCount = 999999;
            this.calVaraus.Name = "calVaraus";
            this.calVaraus.ShowToday = false;
            this.calVaraus.ShowTodayCircle = false;
            this.calVaraus.ShowWeekNumbers = true;
            this.calVaraus.TabIndex = 5;
            this.calVaraus.TitleBackColor = System.Drawing.Color.Yellow;
            this.calVaraus.TrailingForeColor = System.Drawing.Color.Yellow;
            // 
            // lblVarattupvm
            // 
            this.lblVarattupvm.AutoSize = true;
            this.lblVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVarattupvm.Location = new System.Drawing.Point(24, 219);
            this.lblVarattupvm.Name = "lblVarattupvm";
            this.lblVarattupvm.Size = new System.Drawing.Size(133, 17);
            this.lblVarattupvm.TabIndex = 6;
            this.lblVarattupvm.Text = "Varattu Päivämäärä";
            // 
            // dtpVarattupvm
            // 
            this.dtpVarattupvm.Enabled = false;
            this.dtpVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpVarattupvm.Location = new System.Drawing.Point(187, 219);
            this.dtpVarattupvm.Name = "dtpVarattupvm";
            this.dtpVarattupvm.Size = new System.Drawing.Size(239, 23);
            this.dtpVarattupvm.TabIndex = 7;
            // 
            // btnMokintiedot
            // 
            this.btnMokintiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMokintiedot.Location = new System.Drawing.Point(199, 72);
            this.btnMokintiedot.Name = "btnMokintiedot";
            this.btnMokintiedot.Size = new System.Drawing.Size(141, 32);
            this.btnMokintiedot.TabIndex = 8;
            this.btnMokintiedot.Text = "Mökin tiedot";
            this.btnMokintiedot.UseVisualStyleBackColor = true;
            this.btnMokintiedot.Click += new System.EventHandler(this.btnMokintiedot_Click);
            // 
            // btnAsiakkaantiedot
            // 
            this.btnAsiakkaantiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsiakkaantiedot.Location = new System.Drawing.Point(199, 19);
            this.btnAsiakkaantiedot.Name = "btnAsiakkaantiedot";
            this.btnAsiakkaantiedot.Size = new System.Drawing.Size(141, 32);
            this.btnAsiakkaantiedot.TabIndex = 9;
            this.btnAsiakkaantiedot.Text = "Asiakkaan tiedot";
            this.btnAsiakkaantiedot.UseVisualStyleBackColor = true;
            this.btnAsiakkaantiedot.Click += new System.EventHandler(this.btnAsiakkaantiedot_Click);
            // 
            // tbAsiakasnimi
            // 
            this.tbAsiakasnimi.Enabled = false;
            this.tbAsiakasnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAsiakasnimi.Location = new System.Drawing.Point(12, 25);
            this.tbAsiakasnimi.Name = "tbAsiakasnimi";
            this.tbAsiakasnimi.Size = new System.Drawing.Size(135, 22);
            this.tbAsiakasnimi.TabIndex = 10;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Enabled = false;
            this.tbMokkinimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokkinimi.Location = new System.Drawing.Point(12, 78);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(135, 22);
            this.tbMokkinimi.TabIndex = 11;
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkinimi.Location = new System.Drawing.Point(12, 62);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(71, 16);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblAsiakasnimi
            // 
            this.lblAsiakasnimi.AutoSize = true;
            this.lblAsiakasnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakasnimi.Location = new System.Drawing.Point(12, 9);
            this.lblAsiakasnimi.Name = "lblAsiakasnimi";
            this.lblAsiakasnimi.Size = new System.Drawing.Size(99, 16);
            this.lblAsiakasnimi.TabIndex = 13;
            this.lblAsiakasnimi.Text = "Asiakkaan nimi";
            // 
            // Varauksentiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAsiakasnimi);
            this.Controls.Add(this.lblMokkinimi);
            this.Controls.Add(this.tbMokkinimi);
            this.Controls.Add(this.tbAsiakasnimi);
            this.Controls.Add(this.btnAsiakkaantiedot);
            this.Controls.Add(this.btnMokintiedot);
            this.Controls.Add(this.dtpVarattupvm);
            this.Controls.Add(this.lblVarattupvm);
            this.Controls.Add(this.calVaraus);
            this.Controls.Add(this.lblVaraus);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Varauksentiedot";
            this.Text = "Varauksentiedot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.MonthCalendar calVaraus;
        private System.Windows.Forms.Label lblVarattupvm;
        private System.Windows.Forms.DateTimePicker dtpVarattupvm;
        private System.Windows.Forms.Button btnMokintiedot;
        private System.Windows.Forms.Button btnAsiakkaantiedot;
        private System.Windows.Forms.TextBox tbAsiakasnimi;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.Label lblAsiakasnimi;
    }
}