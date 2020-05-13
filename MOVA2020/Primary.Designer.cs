namespace MOVA2020
{
    partial class Primary
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnLaskutus = new System.Windows.Forms.Button();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAsiakastiedot = new System.Windows.Forms.Button();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.btnMuokkaaAsiakas = new System.Windows.Forms.Button();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnToimintaalueentiedot = new System.Windows.Forms.Button();
            this.btnPoistaToimintaalue = new System.Windows.Forms.Button();
            this.btnLisaatoimintaalue = new System.Windows.Forms.Button();
            this.tbLisaaToimintaalueNimi = new System.Windows.Forms.TextBox();
            this.lblLisaaToimintaalueNimi = new System.Windows.Forms.Label();
            this.dgvToimintaalueet = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMokkihaku = new System.Windows.Forms.Button();
            this.btnMokinTiedot = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.btnMuokkaaMokki = new System.Windows.Forms.Button();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbEtsiAsiakkaanNimella = new System.Windows.Forms.TextBox();
            this.lblEtsiNimellaLaskua = new System.Windows.Forms.Label();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblEtsiNimellaLaskua);
            this.tabPage5.Controls.Add(this.tbEtsiAsiakkaanNimella);
            this.tabPage5.Controls.Add(this.btnLaskutus);
            this.tabPage5.Controls.Add(this.dgvLaskut);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(908, 448);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Laskut";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaskutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLaskutus.Location = new System.Drawing.Point(5, 401);
            this.btnLaskutus.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(295, 42);
            this.btnLaskutus.TabIndex = 1;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.UseVisualStyleBackColor = true;
            this.btnLaskutus.Click += new System.EventHandler(this.btnLaskutus_Click);
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.AllowUserToAddRows = false;
            this.dgvLaskut.AllowUserToDeleteRows = false;
            this.dgvLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaskut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLaskut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(304, 7);
            this.dgvLaskut.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLaskut.MultiSelect = false;
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.ReadOnly = true;
            this.dgvLaskut.RowHeadersVisible = false;
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaskut.Size = new System.Drawing.Size(597, 444);
            this.dgvLaskut.TabIndex = 0;
            this.dgvLaskut.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLaskut_ColumnHeaderMouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAsiakastiedot);
            this.tabPage4.Controls.Add(this.btnPoistaAsiakas);
            this.tabPage4.Controls.Add(this.btnMuokkaaAsiakas);
            this.tabPage4.Controls.Add(this.btnLisaaAsiakas);
            this.tabPage4.Controls.Add(this.dgvAsiakkaat);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(908, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asiakkaat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAsiakastiedot
            // 
            this.btnAsiakastiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsiakastiedot.Enabled = false;
            this.btnAsiakastiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsiakastiedot.Location = new System.Drawing.Point(6, 413);
            this.btnAsiakastiedot.Name = "btnAsiakastiedot";
            this.btnAsiakastiedot.Size = new System.Drawing.Size(164, 29);
            this.btnAsiakastiedot.TabIndex = 4;
            this.btnAsiakastiedot.Text = "Asiakkaan tiedot";
            this.btnAsiakastiedot.UseVisualStyleBackColor = true;
            this.btnAsiakastiedot.Click += new System.EventHandler(this.btnAsiakastiedot_Click);
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaAsiakas.Enabled = false;
            this.btnPoistaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(6, 378);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(164, 29);
            this.btnPoistaAsiakas.TabIndex = 3;
            this.btnPoistaAsiakas.Text = "Poista asiakas";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.btnPoistaAsiakas_Click);
            // 
            // btnMuokkaaAsiakas
            // 
            this.btnMuokkaaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMuokkaaAsiakas.Enabled = false;
            this.btnMuokkaaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMuokkaaAsiakas.Location = new System.Drawing.Point(6, 343);
            this.btnMuokkaaAsiakas.Name = "btnMuokkaaAsiakas";
            this.btnMuokkaaAsiakas.Size = new System.Drawing.Size(164, 29);
            this.btnMuokkaaAsiakas.TabIndex = 2;
            this.btnMuokkaaAsiakas.Text = "Muokkaa asiakasta";
            this.btnMuokkaaAsiakas.UseVisualStyleBackColor = true;
            this.btnMuokkaaAsiakas.Click += new System.EventHandler(this.btnMuokkaaAsiakas_Click);
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(6, 8);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(164, 29);
            this.btnLisaaAsiakas.TabIndex = 1;
            this.btnLisaaAsiakas.Text = "Lisää asiakas";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.btnLisaaAsiakas_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsiakkaat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(304, 7);
            this.dgvAsiakkaat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAsiakkaat.MultiSelect = false;
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.ReadOnly = true;
            this.dgvAsiakkaat.RowHeadersVisible = false;
            this.dgvAsiakkaat.RowHeadersWidth = 51;
            this.dgvAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(597, 444);
            this.dgvAsiakkaat.TabIndex = 0;
            this.dgvAsiakkaat.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsiakkaat_ColumnHeaderMouseClick);
            this.dgvAsiakkaat.Click += new System.EventHandler(this.dgvAsiakkaat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnToimintaalueentiedot);
            this.tabPage2.Controls.Add(this.btnPoistaToimintaalue);
            this.tabPage2.Controls.Add(this.btnLisaatoimintaalue);
            this.tabPage2.Controls.Add(this.tbLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.lblLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.dgvToimintaalueet);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toimialueet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnToimintaalueentiedot
            // 
            this.btnToimintaalueentiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToimintaalueentiedot.Enabled = false;
            this.btnToimintaalueentiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToimintaalueentiedot.Location = new System.Drawing.Point(6, 413);
            this.btnToimintaalueentiedot.Name = "btnToimintaalueentiedot";
            this.btnToimintaalueentiedot.Size = new System.Drawing.Size(183, 29);
            this.btnToimintaalueentiedot.TabIndex = 6;
            this.btnToimintaalueentiedot.Text = "Toiminta-alueen tiedot";
            this.btnToimintaalueentiedot.UseVisualStyleBackColor = true;
            this.btnToimintaalueentiedot.Click += new System.EventHandler(this.btnToimintaalueentiedot_Click);
            // 
            // btnPoistaToimintaalue
            // 
            this.btnPoistaToimintaalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaToimintaalue.Enabled = false;
            this.btnPoistaToimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaToimintaalue.Location = new System.Drawing.Point(6, 379);
            this.btnPoistaToimintaalue.Name = "btnPoistaToimintaalue";
            this.btnPoistaToimintaalue.Size = new System.Drawing.Size(183, 28);
            this.btnPoistaToimintaalue.TabIndex = 5;
            this.btnPoistaToimintaalue.Text = "Poista toiminta-alue";
            this.btnPoistaToimintaalue.UseVisualStyleBackColor = true;
            this.btnPoistaToimintaalue.Click += new System.EventHandler(this.btnPoistaToimintaalue_Click);
            // 
            // btnLisaatoimintaalue
            // 
            this.btnLisaatoimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaatoimintaalue.Location = new System.Drawing.Point(7, 55);
            this.btnLisaatoimintaalue.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaatoimintaalue.Name = "btnLisaatoimintaalue";
            this.btnLisaatoimintaalue.Size = new System.Drawing.Size(163, 29);
            this.btnLisaatoimintaalue.TabIndex = 4;
            this.btnLisaatoimintaalue.Text = "Lisää toiminta-alue";
            this.btnLisaatoimintaalue.UseVisualStyleBackColor = true;
            this.btnLisaatoimintaalue.Click += new System.EventHandler(this.btnLisaatoimintaalue_Click);
            // 
            // tbLisaaToimintaalueNimi
            // 
            this.tbLisaaToimintaalueNimi.Location = new System.Drawing.Point(7, 24);
            this.tbLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4);
            this.tbLisaaToimintaalueNimi.Name = "tbLisaaToimintaalueNimi";
            this.tbLisaaToimintaalueNimi.Size = new System.Drawing.Size(163, 23);
            this.tbLisaaToimintaalueNimi.TabIndex = 3;
            // 
            // lblLisaaToimintaalueNimi
            // 
            this.lblLisaaToimintaalueNimi.AutoSize = true;
            this.lblLisaaToimintaalueNimi.Location = new System.Drawing.Point(4, 3);
            this.lblLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLisaaToimintaalueNimi.Name = "lblLisaaToimintaalueNimi";
            this.lblLisaaToimintaalueNimi.Size = new System.Drawing.Size(184, 17);
            this.lblLisaaToimintaalueNimi.TabIndex = 2;
            this.lblLisaaToimintaalueNimi.Text = "Uuden toiminta-alueen nimi:";
            // 
            // dgvToimintaalueet
            // 
            this.dgvToimintaalueet.AllowUserToAddRows = false;
            this.dgvToimintaalueet.AllowUserToDeleteRows = false;
            this.dgvToimintaalueet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToimintaalueet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToimintaalueet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvToimintaalueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimintaalueet.Location = new System.Drawing.Point(304, 7);
            this.dgvToimintaalueet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToimintaalueet.MultiSelect = false;
            this.dgvToimintaalueet.Name = "dgvToimintaalueet";
            this.dgvToimintaalueet.ReadOnly = true;
            this.dgvToimintaalueet.RowHeadersVisible = false;
            this.dgvToimintaalueet.RowHeadersWidth = 51;
            this.dgvToimintaalueet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvToimintaalueet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimintaalueet.ShowCellErrors = false;
            this.dgvToimintaalueet.ShowCellToolTips = false;
            this.dgvToimintaalueet.ShowEditingIcon = false;
            this.dgvToimintaalueet.ShowRowErrors = false;
            this.dgvToimintaalueet.Size = new System.Drawing.Size(597, 444);
            this.dgvToimintaalueet.TabIndex = 0;
            this.dgvToimintaalueet.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvToimintaalueet_ColumnHeaderMouseClick);
            this.dgvToimintaalueet.Click += new System.EventHandler(this.dgvToimintaalueet_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnMokkihaku);
            this.tabPage1.Controls.Add(this.btnMokinTiedot);
            this.tabPage1.Controls.Add(this.btnPoistaMokki);
            this.tabPage1.Controls.Add(this.btnMuokkaaMokki);
            this.tabPage1.Controls.Add(this.btnLisaaMokki);
            this.tabPage1.Controls.Add(this.dgvMokit);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökit";
            // 
            // btnMokkihaku
            // 
            this.btnMokkihaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMokkihaku.Location = new System.Drawing.Point(5, 251);
            this.btnMokkihaku.Margin = new System.Windows.Forms.Padding(2);
            this.btnMokkihaku.Name = "btnMokkihaku";
            this.btnMokkihaku.Size = new System.Drawing.Size(164, 30);
            this.btnMokkihaku.TabIndex = 4;
            this.btnMokkihaku.Text = "Mökki haku";
            this.btnMokkihaku.UseVisualStyleBackColor = true;
            this.btnMokkihaku.Click += new System.EventHandler(this.btnMokkihaku_Click);
            // 
            // btnMokinTiedot
            // 
            this.btnMokinTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMokinTiedot.Enabled = false;
            this.btnMokinTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokinTiedot.Location = new System.Drawing.Point(5, 413);
            this.btnMokinTiedot.Name = "btnMokinTiedot";
            this.btnMokinTiedot.Size = new System.Drawing.Size(164, 29);
            this.btnMokinTiedot.TabIndex = 4;
            this.btnMokinTiedot.Text = "Mökin Tiedot";
            this.btnMokinTiedot.UseVisualStyleBackColor = true;
            this.btnMokinTiedot.Click += new System.EventHandler(this.btnMokinTiedot_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaMokki.Enabled = false;
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(5, 379);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(164, 29);
            this.btnPoistaMokki.TabIndex = 3;
            this.btnPoistaMokki.Text = "Poista Mökki";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnMuokkaaMokki
            // 
            this.btnMuokkaaMokki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMuokkaaMokki.Enabled = false;
            this.btnMuokkaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuokkaaMokki.Location = new System.Drawing.Point(5, 346);
            this.btnMuokkaaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuokkaaMokki.Name = "btnMuokkaaMokki";
            this.btnMuokkaaMokki.Size = new System.Drawing.Size(164, 29);
            this.btnMuokkaaMokki.TabIndex = 2;
            this.btnMuokkaaMokki.Text = "Muokkaa Mökkiä";
            this.btnMuokkaaMokki.UseVisualStyleBackColor = true;
            this.btnMuokkaaMokki.Click += new System.EventHandler(this.btnMuokkaaMokki_Click);
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaMokki.Location = new System.Drawing.Point(5, 5);
            this.btnLisaaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(164, 29);
            this.btnLisaaMokki.TabIndex = 1;
            this.btnLisaaMokki.Text = "Lisää Mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // dgvMokit
            // 
            this.dgvMokit.AllowUserToAddRows = false;
            this.dgvMokit.AllowUserToDeleteRows = false;
            this.dgvMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(304, 7);
            this.dgvMokit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMokit.MultiSelect = false;
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMokit.Size = new System.Drawing.Size(597, 444);
            this.dgvMokit.TabIndex = 0;
            this.dgvMokit.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMokit_ColumnHeaderMouseClick);
            this.dgvMokit.Click += new System.EventHandler(this.dgvMokit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tbEtsiAsiakkaanNimella
            // 
            this.tbEtsiAsiakkaanNimella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEtsiAsiakkaanNimella.Location = new System.Drawing.Point(6, 46);
            this.tbEtsiAsiakkaanNimella.Name = "tbEtsiAsiakkaanNimella";
            this.tbEtsiAsiakkaanNimella.Size = new System.Drawing.Size(164, 26);
            this.tbEtsiAsiakkaanNimella.TabIndex = 2;
            this.tbEtsiAsiakkaanNimella.TextChanged += new System.EventHandler(this.tbEtsiAsiakkaanNimella_TextChanged);
            // 
            // lblEtsiNimellaLaskua
            // 
            this.lblEtsiNimellaLaskua.AutoSize = true;
            this.lblEtsiNimellaLaskua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEtsiNimellaLaskua.Location = new System.Drawing.Point(5, 23);
            this.lblEtsiNimellaLaskua.Name = "lblEtsiNimellaLaskua";
            this.lblEtsiNimellaLaskua.Size = new System.Drawing.Size(165, 20);
            this.lblEtsiNimellaLaskua.TabIndex = 3;
            this.lblEtsiNimellaLaskua.Text = "Etsi asiakkaan nimellä";
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 496);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(950, 534);
            this.Name = "Primary";
            this.Text = "MOVA2020";
            this.Load += new System.EventHandler(this.Primary_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnLaskutus;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAsiakastiedot;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.Button btnMuokkaaAsiakas;
        private System.Windows.Forms.Button btnLisaaAsiakas;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnToimintaalueentiedot;
        private System.Windows.Forms.Button btnPoistaToimintaalue;
        private System.Windows.Forms.Button btnLisaatoimintaalue;
        private System.Windows.Forms.TextBox tbLisaaToimintaalueNimi;
        private System.Windows.Forms.Label lblLisaaToimintaalueNimi;
        private System.Windows.Forms.DataGridView dgvToimintaalueet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMokinTiedot;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnMuokkaaMokki;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnMokkihaku;
        private System.Windows.Forms.Label lblEtsiNimellaLaskua;
        private System.Windows.Forms.TextBox tbEtsiAsiakkaanNimella;
    }
}

