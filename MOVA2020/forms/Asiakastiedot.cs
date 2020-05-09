using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs.dbitems;
using MOVA2020.objs;
using MOVA2020;
namespace MOVA2020.forms
{
    /*
     * 
     * Tehnyt: Tommi Puurunen
     * Toteuttaa toiminnallisuusmäärittelyn
     *      4.2.4 Asiakkaan tiedot
     *      
     *      4.2.15 Varauksen lisäys
     *      4.2.16 Varauksen muokkaus
     *      4.2.17 Varauksen poisto
     */
    public partial class Asiakastiedot : Form
    {
        private Asiakas asiakas;
        private Primary paalomake;

        public Asiakastiedot(Primary p, Asiakas a)
        {
            this.asiakas = a;
            this.paalomake = p;
            InitializeComponent();
            tbEtunimi.Text = a.Etunimi;
            tbSukunimi.Text = a.Sukunimi;

            tbKatuosoite.Text = a.Lahiosoite;
            tbPaikkakunta.Text = a.Posti.Toimipaikka;
            tbPostinumero.Text = a.Posti.Postinro;

            tbPuhnro.Text = a.Puhelinnro;
            tbSahkoposti.Text = a.Email;

            this.paivita();
        }

        public void paivita()
        {
            this.paalomake.paivita();
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = this.HaeVaraukset;
        }
        private List<Varaus> HaeVaraukset => this.paalomake.Varaukset.FindAll(i => i.Asiakas.Asiakas_id == this.asiakas.Asiakas_id);
        private void dgvVaraukset_Click(object sender, EventArgs e)
        {
            if(dgvVaraukset.SelectedRows.Count > 0)
            {
                btnPoistaVaraus.Enabled = true;
                btnMuokkaaVarausta.Enabled = true;
                btnVaraustiedot.Enabled = true;
            } else
            {
                btnPoistaVaraus.Enabled = false;
                btnMuokkaaVarausta.Enabled = false;
                btnVaraustiedot.Enabled = false;
            }
        }

        private void btnLisaaVaraus_Click(object sender, EventArgs e)
        {
            Varauksenmuokkaus vl = new Varauksenmuokkaus(this, this.paalomake, this.asiakas);
            vl.Show();
        }

        private void btnMuokkaaVarausta_Click(object sender, EventArgs e)
        {

            Varaus v = (Varaus)dgvVaraukset.SelectedRows[0].DataBoundItem;
            if (!v.Vahvistus_pvm.Equals(DateTime.Parse("1970-01-01 00:00:00")))
            {
                Varauksenmuokkaus vm = new Varauksenmuokkaus(this, this.paalomake, this.asiakas, v);
                vm.Show();
            } else
            {
                MessageBox.Show("Varaus on jo maksettu ja ei voida enään muuttaa!", "Varauksen muokkaaminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVaraustiedot_Click(object sender, EventArgs e)
        {
            Varaus v = (Varaus)dgvVaraukset.SelectedRows[0].DataBoundItem;
            Varauksentiedot vt = new Varauksentiedot(this.paalomake, v);
            vt.Show();
        }

        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            Varaus v = (Varaus)dgvVaraukset.SelectedRows[0].DataBoundItem;
            DialogResult dr = MessageBox.Show("Haluatko poistaa varauksen " + v.Mokki.Mokkinimi + " " + " ?", "Poista Varaus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$varaus_id", v.Varaus_id);
                string query = "DELETE FROM varaus WHERE varaus_id = $varaus_id";
                this.paalomake.Db.DMquery(query, pairs);
                this.paivita();
            }
        }
    }
}
