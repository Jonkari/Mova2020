using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MOVA2020.objs;
using MOVA2020.objs.dbitems;
using MOVA2020.forms;
namespace MOVA2020
{
    /*
    * MOVA2020
    * Tekijä: Teija Tilli, Tommi Puurunen, Jonna Räsänen, Roosa Turunen, Pauli Pursiainen
    * 
    * Toteuttaa  toiminnallisuusmäärittelyn 
    *      4.2.1 Asiakkaan lisäys
    *      4.2.2 Asiakkaan muokkaus
    *      4.2.3 Asiakkaan poisto
    *      
    *      4.2.5 Mökin lisäys
    *      4.2.6 Mökin muokkaaminen
    *      4.2.7 Mökin poisto
    *      4.2.8 Mökin tiedot
    *      4.2.9 Mökin haku
    *      
    *      4.2.10 Toiminta-alueen lisäys
    *      4.2.11 Toiminta-alueen poisto
    */
    public partial class Primary : Form
    {
        private DBHandler db = new DBHandler();
        private List<Mokki> mokit = new List<Mokki>();
        private List<Toimintaalue> toimintaalueet = new List<Toimintaalue>();
        private List<Posti> postinumerot = new List<Posti>();
        private List<Varaus> varaukset = new List<Varaus>();
        private List<Lasku> laskut = new List<Lasku>();
        private List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<Palvelu> palvelut = new List<Palvelu>();

        public DBHandler Db { get => db; set => db = value; }
        public List<Mokki> Mokit { get => mokit; set => mokit = value; }
        public List<Toimintaalue> Toimintaalueet { get => toimintaalueet; set => toimintaalueet = value; }
        public List<Posti> Postinumerot { get => postinumerot; set => postinumerot = value; }
        public List<Varaus> Varaukset { get => varaukset; set => varaukset = value; }
        public List<Lasku> Laskut { get => laskut; set => laskut = value; }
        public List<Asiakas> Asiakkaat { get => asiakkaat; set => asiakkaat = value; }
        public List<Palvelu> Palvelut { get => palvelut; set => palvelut = value; }

        public Primary()
        {
            InitializeComponent();
            this.paivita();            
        }

        public void paivita()
        {
            //Päivitetään datagridit ja listat, jaettu pienempiin funktioihin.
            
            this.PaivitaPostinumerot();
            this.PaivitaToimintaalueet();
            this.PaivitaMokit();
            this.PaivitaAsiakkaat();
            this.PaivitaPalvelut();
            this.PaivitaVaraukset();
            this.PaivitaLaskut();
        }

        private void PaivitaAsiakkaat()
        {
            this.Asiakkaat.Clear();
            List<Object[]> asiakkaatquery = this.Db.SelectQuery("SELECT * FROM asiakas");
            foreach(Object[] itemarr in asiakkaatquery)
            {
                Posti p = Postinumerot.Find(i => i.Postinro == (string)itemarr[1]);
                var email = itemarr[5] as String;
                if(email == null)
                {
                    email = "";
                }
                Asiakas a = new Asiakas((long)itemarr[0], (string)itemarr[2], (string)itemarr[3], (string)itemarr[4], email, (string)itemarr[6], p);
                this.Asiakkaat.Add(a);
            }
            dgvAsiakkaat.DataSource = null;
            if (Asiakkaat.Count > 0) {
                dgvAsiakkaat.DataSource = Asiakkaat;
            }
            
        }
        private void PaivitaPostinumerot()
        {
            this.Postinumerot.Clear();
            List<Object[]> postinumerotquery = this.Db.SelectQuery("SELECT * FROM posti");
            foreach (Object[] itemarr in postinumerotquery)
            {
                Posti p = new Posti((string)itemarr[0], (string)itemarr[1]);
                this.Postinumerot.Add(p);
            }

        }
        private void PaivitaToimintaalueet()
        {
            this.Toimintaalueet.Clear();
            List<Object[]> toimintaalueetquery = this.Db.SelectQuery("SELECT * FROM toimintaalue");
            foreach (Object[] itemarr in toimintaalueetquery)
            {
                Toimintaalue t = new Toimintaalue((long)itemarr[0], (string)itemarr[1]);
                this.Toimintaalueet.Add(t);
            }
            dgvToimintaalueet.DataSource = null;
            if (this.Toimintaalueet.Count > 0) { 
                dgvToimintaalueet.DataSource = this.Toimintaalueet;
            }
        }
        private void PaivitaMokit()
        {
            this.Mokit.Clear();
            List<Object[]> mokitquery = this.Db.SelectQuery("SELECT * FROM mokki");
            foreach (Object[] itemarr in mokitquery)
            {
                Toimintaalue t = Toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Posti p = Postinumerot.Find(i => i.Postinro == (string)itemarr[2]);
                Mokki m = new Mokki(
                    (long)itemarr[0],
                    (string)itemarr[3],
                    (string)itemarr[5],
                    (string)itemarr[6],
                    (string)itemarr[8],
                    p,
                    t,
                    (double)itemarr[4],
                    (int)(long)itemarr[7]);
                this.Mokit.Add(m);
            }
            
            dgvMokit.DataSource = null;
            if (this.Mokit.Count > 0)
            {
                dgvMokit.DataSource = this.Mokit;
            }
    }
        private void PaivitaPalvelut()
        {
            this.Palvelut.Clear();
            List<Object[]> palvelutquery = this.Db.SelectQuery("SELECT * FROM palvelu");
            foreach(Object[] itemarr in palvelutquery)
            {
                Toimintaalue t = Toimintaalueet.Find(i => i.Toiminta_alueid == (long)itemarr[1]);
                Palvelu p = new Palvelu((long)itemarr[0], (int)(long)itemarr[3], (string)itemarr[2], (string)itemarr[4], (double)itemarr[5], (double)itemarr[6], t);
                this.Palvelut.Add(p);
            }
        }
        private void PaivitaLaskut()
        {
            this.Laskut.Clear();
            List<Object[]> laskuquery = this.Db.SelectQuery("SELECT * FROM lasku");
            foreach (Object[] itemarr in laskuquery)
            {
                Varaus v = Varaukset.Find(i => i.Varaus_id == (long)itemarr[1]);
                Lasku l = new Lasku((long)itemarr[0], (double)itemarr[2], (double)itemarr[3], v);
                Laskut.Add(l);
            }
            this.dgvLaskut.DataSource = null;
            if (this.Laskut.Count > 0) {
                this.dgvLaskut.DataSource = Laskut;
            }
        }
        private void PaivitaVaraukset()
        {
            this.Varaukset.Clear();
            List<Object[]> varausquery = this.Db.SelectQuery("SELECT * FROM varaus");
            foreach(Object[] itemarr in varausquery)
            {
                Dictionary<int, int> varauksenpalvelut = new Dictionary<int, int>();
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$varausid", itemarr[0]);
                List<Object[]> varauksenpalvelutquery = this.Db.SelectQuery("SELECT * FROM varauksen_palvelut WHERE varaus_id=$varausid", pairs);
                foreach(Object[] palvelu in varauksenpalvelutquery)
                {
                    varauksenpalvelut.Add((int)(long)palvelu[1], (int)(long)palvelu[2]);
                }
                
                Asiakas a = Asiakkaat.Find(i => i.Asiakas_id == (long)itemarr[1]);
                Mokki m = Mokit.Find(i => i.Mokki_id == (long)itemarr[2]);
                var date = itemarr[4] as String;
                DateTime t = DateTime.Parse("1970-01-01 00:00:00");
                if(date != null)
                {
                    t = DateTime.Parse(date);
                }
                
                Varaus v = new Varaus((long)itemarr[0], DateTime.Parse((string)itemarr[3]), t, DateTime.Parse((string)itemarr[5]), DateTime.Parse((string)itemarr[6]), a, m, varauksenpalvelut);
                this.Varaukset.Add(v);
            }
        }
        private void btnLisaatoimintaalue_Click(object sender, EventArgs e)
        {

            if(tbLisaaToimintaalueNimi.Text.Length == 0)
            {
                MessageBox.Show("Toiminta-alueella pitää olla nimi!", "Virhe", MessageBoxButtons.OK);
                return;
            }
            // SQL kysely
            string query = "INSERT INTO toimintaalue(nimi) VALUES($nimi)";
            /*
                Luodaan dictionary jossa lisätään kyselyssä olevat $nimi, muuttujaksi nimi
            */ 
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("$nimi", tbLisaaToimintaalueNimi.Text);
            if(this.Db.DMquery(query, pairs) !=-1)
            {
                this.paivita();
            } else
            {
                MessageBox.Show("error");
            }         
        }

        private void Primary_Load(object sender, EventArgs e)
        {

        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            //4.2.5 Mökin lisäys
            //aukaisee mokkimuokkaus filen
            Mokkimuokkaus lisaamokki = new Mokkimuokkaus(this);
            lisaamokki.ShowDialog();
        }

        private void btnMuokkaaMokki_Click(object sender, EventArgs e)
        {
            //4.2.6 Mökin muokkaaminen
            //aukaiseen mokkimuokkaus filen valitun mokin tiedoista
            Mokkimuokkaus mokkimuokkaus = new Mokkimuokkaus(this, (Mokki)dgvMokit.SelectedRows[0].DataBoundItem);
            mokkimuokkaus.ShowDialog();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            //4.2.7 Mökin poisto
            //tekee merkkiäänen ja aukaisee varmennus_kysely_poistosta-messageboxin
            SystemSounds.Beep.Play();
            varmennus_kysely_poistosta varmennus = new varmennus_kysely_poistosta(this, (Mokki)dgvMokit.SelectedRows[0].DataBoundItem);
            varmennus.ShowDialog();
        }

        private void btnMokinTiedot_Click(object sender, EventArgs e)
        {
            //4.2.8 Mökin tiedot
            //aukaisee valitun mökin tiedot
            Mokki mokki = (Mokki)dgvMokit.SelectedRows[0].DataBoundItem;
            Mokkitiedot mokkitiedotjapalvelut = new Mokkitiedot(this, mokki);
            mokkitiedotjapalvelut.ShowDialog();
        }

        private void dgvMokit_Click(object sender, EventArgs e)
        {
            //muokkaa ja poista napit eivät ole valittavissa, jos riviä ei ole valittu datagridviewissä
            if (dgvMokit.SelectedRows.Count > 0)
            {
                btnMuokkaaMokki.Enabled = true;
                btnPoistaMokki.Enabled = true;
                btnMokinTiedot.Enabled = true;
            }
            else
            {
                btnMuokkaaMokki.Enabled = false;
                btnPoistaMokki.Enabled = false;
                btnMokinTiedot.Enabled = false;
            }
        }

        private void dgvLaskut_Click(object sender, EventArgs e)
        {
            if (dgvLaskut.SelectedRows.Count > 0)
            {
                btnLaskutus.Enabled = true;
            }
            else
            {
                btnLaskutus.Enabled = false;
            }
        }

        // 3.3 Avaa laskutusformin valitun varauksen tiedoilla
        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            Lasku l = (Lasku)dgvLaskut.SelectedRows[0].DataBoundItem;
            Laskutus lt = new Laskutus(this, l);
            lt.Show();
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            //4.2.1 Asiakkaan lisäys, siirrytään tyhjälle Asiakasmuokkaus -formille.
            Asiakasmuokkaus at = new Asiakasmuokkaus(this);
            at.Show();
        }

        private void btnMuokkaaAsiakas_Click(object sender, EventArgs e)
        {
            //4.2.2 Asiakkaan muokkaus, siirrytään Asiakasmuokkaus -formille, johon viedään asiakkaan aiemmat tiedot. 
            Asiakas a = (Asiakas)dgvAsiakkaat.SelectedRows[0].DataBoundItem;
            Asiakasmuokkaus at = new Asiakasmuokkaus(this, a);
            at.Show();
        }

        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            //4.2.3 Asiakkaan poisto, varmistusten jälkeen poistetaan asiakas laskutus ja varaus tietoineen. 
            Asiakas asiakas = (Asiakas)dgvAsiakkaat.SelectedRows[0].DataBoundItem;
            DialogResult dr = MessageBox.Show("Haluatko poistaa asiakkaan " + asiakas.ToString() 
                + " ?\nTämä poistaa kaikki laskut ja varaukset!", "Poista Asiakas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$asiakas_id", asiakas.Asiakas_id);

                string query = "DELETE FROM asiakas WHERE asiakas_id = $asiakas_id";
                this.Db.DMquery(query, pairs);
                this.paivita();
            }
        }

        private void btnAsiakastiedot_Click(object sender, EventArgs e)
        {
            Asiakas asiakas = (Asiakas)dgvAsiakkaat.SelectedRows[0].DataBoundItem;
            Asiakastiedot at = new Asiakastiedot(this, asiakas);
            at.Show();
        }

        private void dgvAsiakkaat_Click(object sender, EventArgs e)
        {
            //sallitaan vain tietyt napit jos asiakas on valittu
            if (dgvAsiakkaat.SelectedRows.Count > 0)
            {
                btnMuokkaaAsiakas.Enabled = true;
                btnPoistaAsiakas.Enabled = true;
                btnAsiakastiedot.Enabled = true;
            }
            else
            {
                btnMuokkaaAsiakas.Enabled = false;
                btnPoistaAsiakas.Enabled = false;
                btnAsiakastiedot.Enabled = false;
            }
        }

        private void dgvToimintaalueet_Click(object sender, EventArgs e)
        {
            //sallitaan vain tietyt napit jos toiminta-alue on valittu
            if (dgvToimintaalueet.SelectedRows.Count > 0)
            {
                btnPoistaToimintaalue.Enabled = true;
                btnToimintaalueentiedot.Enabled = true;
            } else
            {
                btnPoistaToimintaalue.Enabled = false;
                btnToimintaalueentiedot.Enabled = false;
            }
        }

        private void btnPoistaToimintaalue_Click(object sender, EventArgs e)
        {
            //4.2.11, Toiminta-alueen poisto, Poistetaan toiminta-alue, mutta ei sallita ellei ensimmäisenä poistetä palveluita ja mökkejä
            Toimintaalue t = (Toimintaalue)dgvToimintaalueet.SelectedRows[0].DataBoundItem;
            DialogResult dr = MessageBox.Show("Haluatko poistaa Toimialueen " + t.Nimi + " ?\nTämä ei onnistu ilman, että poistat ensimmäisenä kaikki palvelut ja mökit!", "Poista Toiminta-alue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$toimintaalue_id", t.Toiminta_alueid);

                string query = "DELETE FROM toimintaalue WHERE toimintaalue_id = $toimintaalue_id";
                if(this.Db.DMquery(query, pairs) == -1)
                {
                    MessageBox.Show("Poisto epäonnistui, muista poistaa ensimmäiseksi palvelut ja mökit!");
                }
                this.paivita();
            }
        }

        private void btnToimintaalueentiedot_Click(object sender, EventArgs e)
        {

            if (dgvToimintaalueet.SelectedRows.Count > 0) {
                Toimintaalue t = (Toimintaalue)dgvToimintaalueet.SelectedRows[0].DataBoundItem;
                Toimintaalueentiedot tt = new Toimintaalueentiedot(this, t);
                tt.Show();
            }
        }
        private void dgvMokit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //järjestetään mökit datagrid
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            string column = grid.Columns[e.ColumnIndex].Name;
            dgvMokit.DataSource = null;
            if (column.Equals("Varustelu"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Varustelu).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Varustelu).ToList();
                }
            }
            else if (column.Equals("Mokkinimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Mokkinimi).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Mokkinimi).ToList();
                }
            }
            else if(column.Equals("Hinta"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Hinta).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Hinta).ToList();
                }
            }
            else if (column.Equals("Henkilomaara"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Henkilomaara).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Henkilomaara).ToList();
                }
            }
            else if (column.Equals("Toimintaalue"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Toimintaalue.Nimi).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Toimintaalue.Nimi).ToList();
                }

            }
            else if (column.Equals("Mokki_id"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvMokit.DataSource = this.Mokit.OrderBy(x => x.Mokki_id).ToList();
                }
                else
                {
                    dgvMokit.DataSource = this.Mokit.OrderByDescending(x => x.Mokki_id).ToList();
                }

            }
            else
            {
                dgvMokit.DataSource = this.Mokit;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }



        private void dgvToimintaalueet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //järjestetään toiminta-alue datagrid
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Toiminta_alueid"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderBy(x => x.Toiminta_alueid).ToList();
                }
                else
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderByDescending(x => x.Toiminta_alueid).ToList();
                }
            }
            else if (column.Equals("Nimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderBy(x => x.Nimi).ToList();
                }
                else
                {
                    dgvToimintaalueet.DataSource = this.toimintaalueet.OrderByDescending(x => x.Nimi).ToList();
                }
            }

            else
            {
                dgvToimintaalueet.DataSource = this.toimintaalueet;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
        private void dgvAsiakkaat_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //järjestetään asiakas datagrid
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Etunimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderBy(x => x.Etunimi).ToList();
                }
                else
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderByDescending(x => x.Etunimi).ToList();
                }
            }
            else if (column.Equals("Sukunimi"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderBy(x => x.Sukunimi).ToList();
                }
                else
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderByDescending(x => x.Sukunimi).ToList();
                }
            }
            else if (column.Equals("Lahiosoite"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderBy(x => x.Lahiosoite).ToList();
                }
                else
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderByDescending(x => x.Lahiosoite).ToList();
                }
            }
            else if (column.Equals("Asiakas_id"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderBy(x => x.Asiakas_id).ToList();
                }
                else
                {
                    dgvAsiakkaat.DataSource = this.Asiakkaat.OrderByDescending(x => x.Asiakas_id).ToList();
                }
            }
            else
            {
                dgvAsiakkaat.DataSource = this.Asiakkaat;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }

        private void dgvLaskut_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //järjestetään lasku datagrid
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Lasku_id"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvLaskut.DataSource = this.laskut.OrderBy(x => x.Lasku_id).ToList();
                }
                else
                {
                    dgvLaskut.DataSource = this.laskut.OrderByDescending(x => x.Lasku_id).ToList();
                }
            }
            else if (column.Equals("Erapaiva"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvLaskut.DataSource = this.laskut.OrderBy(x => x.Erapaiva).ToList();
                }
                else
                {
                    dgvLaskut.DataSource = this.laskut.OrderByDescending(x => x.Erapaiva).ToList();
                }
            }
            else if (column.Equals("Varaus"))
            {
                if (so == SortOrder.Ascending)
                {
                    dgvLaskut.DataSource = this.laskut.OrderBy(x => x.Varaus.Alkupvm_varaus).ToList();
                }
                else
                {
                    dgvLaskut.DataSource = this.laskut.OrderByDescending(x => x.Varaus.Alkupvm_varaus).ToList();
                }
            }

            else
            {
                dgvToimintaalueet.DataSource = this.laskut;
            }
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
        private void btnMokkihaku_Click(object sender, EventArgs e)
        {
            Mokinhaku mh = new Mokinhaku(this);
            mh.Show();
        }
    }
}
