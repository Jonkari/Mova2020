namespace MOVA2020.forms
{
    partial class Mokinhaku
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
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tbHaku = new System.Windows.Forms.TextBox();
            this.cbJarjestely = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMokinjarjestely = new System.Windows.Forms.Label();
            this.btnValitsemokki = new System.Windows.Forms.Button();
            this.btnMokintiedot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMokit
            // 
            this.dgvMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(223, 12);
            this.dgvMokit.MinimumSize = new System.Drawing.Size(565, 426);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMokit.Size = new System.Drawing.Size(565, 426);
            this.dgvMokit.TabIndex = 0;
            // 
            // tbHaku
            // 
            this.tbHaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHaku.Location = new System.Drawing.Point(12, 81);
            this.tbHaku.Name = "tbHaku";
            this.tbHaku.Size = new System.Drawing.Size(188, 23);
            this.tbHaku.TabIndex = 1;
            this.tbHaku.TextChanged += new System.EventHandler(this.tbHaku_TextChanged);
            // 
            // cbJarjestely
            // 
            this.cbJarjestely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJarjestely.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbJarjestely.FormattingEnabled = true;
            this.cbJarjestely.Location = new System.Drawing.Point(12, 33);
            this.cbJarjestely.Name = "cbJarjestely";
            this.cbJarjestely.Size = new System.Drawing.Size(188, 24);
            this.cbJarjestely.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etsi";
            // 
            // lblMokinjarjestely
            // 
            this.lblMokinjarjestely.AutoSize = true;
            this.lblMokinjarjestely.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMokinjarjestely.Location = new System.Drawing.Point(9, 13);
            this.lblMokinjarjestely.Name = "lblMokinjarjestely";
            this.lblMokinjarjestely.Size = new System.Drawing.Size(127, 17);
            this.lblMokinjarjestely.TabIndex = 4;
            this.lblMokinjarjestely.Text = "Mökin haku sarake";
            // 
            // btnValitsemokki
            // 
            this.btnValitsemokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnValitsemokki.Location = new System.Drawing.Point(15, 405);
            this.btnValitsemokki.Name = "btnValitsemokki";
            this.btnValitsemokki.Size = new System.Drawing.Size(185, 33);
            this.btnValitsemokki.TabIndex = 5;
            this.btnValitsemokki.Text = "Valitse mökki";
            this.btnValitsemokki.UseVisualStyleBackColor = true;
            this.btnValitsemokki.Click += new System.EventHandler(this.btnValitsemokki_Click);
            // 
            // btnMokintiedot
            // 
            this.btnMokintiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMokintiedot.Location = new System.Drawing.Point(12, 110);
            this.btnMokintiedot.Name = "btnMokintiedot";
            this.btnMokintiedot.Size = new System.Drawing.Size(188, 33);
            this.btnMokintiedot.TabIndex = 6;
            this.btnMokintiedot.Text = "Mökin tiedot";
            this.btnMokintiedot.UseVisualStyleBackColor = true;
            this.btnMokintiedot.Click += new System.EventHandler(this.btnMokintiedot_Click);
            // 
            // Mokinhaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMokintiedot);
            this.Controls.Add(this.btnValitsemokki);
            this.Controls.Add(this.lblMokinjarjestely);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJarjestely);
            this.Controls.Add(this.tbHaku);
            this.Controls.Add(this.dgvMokit);
            this.Name = "Mokinhaku";
            this.Text = "Mokin haku";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.TextBox tbHaku;
        private System.Windows.Forms.ComboBox cbJarjestely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMokinjarjestely;
        private System.Windows.Forms.Button btnValitsemokki;
        private System.Windows.Forms.Button btnMokintiedot;
    }
}