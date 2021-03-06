namespace MOVA2020.forms
{
    partial class Palvelunmuokkaus
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
            this.btnPalvelu = new System.Windows.Forms.Button();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.rtbKuvaus = new System.Windows.Forms.RichTextBox();
            this.tbHintaEiAlv = new System.Windows.Forms.TextBox();
            this.tbALV = new System.Windows.Forms.TextBox();
            this.lblHintaEiALV = new System.Windows.Forms.Label();
            this.lblALV = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblNimi = new System.Windows.Forms.Label();
            this.tbHintaSisALV = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalvelu
            // 
            this.btnPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPalvelu.Location = new System.Drawing.Point(15, 343);
            this.btnPalvelu.Name = "btnPalvelu";
            this.btnPalvelu.Size = new System.Drawing.Size(245, 33);
            this.btnPalvelu.TabIndex = 4;
            this.btnPalvelu.Text = "Lisää";
            this.btnPalvelu.UseVisualStyleBackColor = true;
            this.btnPalvelu.Click += new System.EventHandler(this.btnPalvelu_Click);
            // 
            // tbNimi
            // 
            this.tbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNimi.Location = new System.Drawing.Point(15, 29);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(245, 23);
            this.tbNimi.TabIndex = 1;
            // 
            // rtbKuvaus
            // 
            this.rtbKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbKuvaus.Location = new System.Drawing.Point(15, 75);
            this.rtbKuvaus.Name = "rtbKuvaus";
            this.rtbKuvaus.Size = new System.Drawing.Size(245, 117);
            this.rtbKuvaus.TabIndex = 2;
            this.rtbKuvaus.Text = "";
            // 
            // tbHintaEiAlv
            // 
            this.tbHintaEiAlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHintaEiAlv.Location = new System.Drawing.Point(15, 215);
            this.tbHintaEiAlv.Name = "tbHintaEiAlv";
            this.tbHintaEiAlv.Size = new System.Drawing.Size(100, 23);
            this.tbHintaEiAlv.TabIndex = 3;
            this.tbHintaEiAlv.TextChanged += new System.EventHandler(this.tbHintaEiAlv_TextChanged);
            this.tbHintaEiAlv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHintaEiAlv_KeyPress);
            // 
            // tbALV
            // 
            this.tbALV.Enabled = false;
            this.tbALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbALV.Location = new System.Drawing.Point(15, 256);
            this.tbALV.Name = "tbALV";
            this.tbALV.Size = new System.Drawing.Size(100, 23);
            this.tbALV.TabIndex = 5;
            // 
            // lblHintaEiALV
            // 
            this.lblHintaEiALV.AutoSize = true;
            this.lblHintaEiALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHintaEiALV.Location = new System.Drawing.Point(12, 195);
            this.lblHintaEiALV.Name = "lblHintaEiALV";
            this.lblHintaEiALV.Size = new System.Drawing.Size(106, 17);
            this.lblHintaEiALV.TabIndex = 6;
            this.lblHintaEiALV.Text = "Hinta (Ei ALV) *";
            // 
            // lblALV
            // 
            this.lblALV.AutoSize = true;
            this.lblALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblALV.Location = new System.Drawing.Point(13, 241);
            this.lblALV.Name = "lblALV";
            this.lblALV.Size = new System.Drawing.Size(43, 17);
            this.lblALV.TabIndex = 7;
            this.lblALV.Text = "ALV *";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKuvaus.Location = new System.Drawing.Point(12, 55);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(55, 17);
            this.lblKuvaus.TabIndex = 8;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNimi.Location = new System.Drawing.Point(12, 9);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(44, 17);
            this.lblNimi.TabIndex = 9;
            this.lblNimi.Text = "Nimi *";
            // 
            // tbHintaSisALV
            // 
            this.tbHintaSisALV.Enabled = false;
            this.tbHintaSisALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHintaSisALV.Location = new System.Drawing.Point(15, 302);
            this.tbHintaSisALV.Name = "tbHintaSisALV";
            this.tbHintaSisALV.Size = new System.Drawing.Size(100, 23);
            this.tbHintaSisALV.TabIndex = 11;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHinta.Location = new System.Drawing.Point(12, 282);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(115, 17);
            this.lblHinta.TabIndex = 12;
            this.lblHinta.Text = "Hinta (sis. ALV) *";
            // 
            // Palvelunmuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 388);
            this.Controls.Add(this.lblHinta);
            this.Controls.Add(this.tbHintaSisALV);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.lblALV);
            this.Controls.Add(this.lblHintaEiALV);
            this.Controls.Add(this.tbALV);
            this.Controls.Add(this.tbHintaEiAlv);
            this.Controls.Add(this.rtbKuvaus);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.btnPalvelu);
            this.MinimumSize = new System.Drawing.Size(287, 427);
            this.Name = "Palvelunmuokkaus";
            this.Text = "Palvelunmuokkaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalvelu;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.RichTextBox rtbKuvaus;
        private System.Windows.Forms.TextBox tbHintaEiAlv;
        private System.Windows.Forms.TextBox tbALV;
        private System.Windows.Forms.Label lblHintaEiALV;
        private System.Windows.Forms.Label lblALV;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.TextBox tbHintaSisALV;
        private System.Windows.Forms.Label lblHinta;
    }
}