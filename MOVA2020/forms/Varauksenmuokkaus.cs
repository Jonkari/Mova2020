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
namespace MOVA2020.forms
{
    public partial class Varauksenmuokkaus : Form
    {
        /*
         * 
         * Tekijä: Jonna Räsänen, Tommi Puurunen 
         * 
         * Toteuttaa toiminnallisuusmäärittelyn
         *      4.2.15 Varauksen lisäys
         *      4.2.16 Varauksen muokkaus
         */ 
        public struct VarauksenPalvelu
        {
            public Palvelu p;
            public int lkm;
            override
            public string ToString()
            {
                return p.ToString() + " Lukumäärä:" + lkm.ToString();
            }
        }
        private Primary lomake;
        private Asiakastiedot att;
        private Asiakas a;
        private Varaus v = null;

        public Primary Lomake { get => lomake; set => lomake = value; }

        public Varauksenmuokkaus(Asiakastiedot att, Primary p, Asiakas a)
        {
            this.att = att;
            this.Lomake = p;
            this.a = a;
            InitializeComponent();
            lbVarauksenPalvelut.DataSource = null;
            cbToimintaalueet.DataSource = this.Lomake.Toimintaalueet;
            calVaraus.MinDate = DateTime.Now;
            this.Text = "Varauksen lisäys";
            this.btvaraus.Text = "Tee varaus";
        }
        public Varauksenmuokkaus(Asiakastiedot att, Primary p, Asiakas a, Varaus v)
        {
            this.att = att;
            this.Lomake = p;
            this.a = a;
            this.v = v;
            InitializeComponent();
            lbVarauksenPalvelut.DataSource = null;
            calVaraus.MinDate = DateTime.Now;
            cbToimintaalueet.Items.Add(v.Mokki.Toimintaalue);
            cbToimintaalueet.SelectedIndex = 0;
            cbToimintaalueet.Enabled = false;
            CBMokki.Enabled = false;
            this.Text = "Varauksen muokkaus";
            this.btvaraus.Text = "Muokkaa varausta";
            calVaraus.SelectionRange.Start = this.v.Alkupvm_varaus;
            calVaraus.SelectionRange.End = this.v.Loppupvm_varaus;


            foreach(KeyValuePair<int, int> item in v.Varauksenpalvelut)
            {
                Palvelu pp = this.Lomake.Palvelut.Find(i => i.Palvelu_id == item.Key);
                VarauksenPalvelu vp;
                vp.p = pp;
                vp.lkm = item.Value;
                lbVarauksenPalvelut.Items.Add(vp);
            }




        }
        public void paivita()
        {
            this.Lomake.paivita();
            this.att.paivita();
        }
        private void btvaraus_Click(object sender, EventArgs e)
        {
            if (this.CBMokki.SelectedIndex != -1) {
                string query;
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$asiakas", a.Asiakas_id);
                pairs.Add("$mokki_id", ((Mokki)this.CBMokki.SelectedItem).Mokki_id);
                pairs.Add("$varattu_pvm", DateTime.Now);
                pairs.Add("$varaus_alkupvm", calVaraus.SelectionRange.Start);
                pairs.Add("$varaus_loppupvm", calVaraus.SelectionRange.End);

                if (this.MokkiVapaana())
                {
                    if (v == null)
                    {
                        double summa = 0;
                        double days;
                        query = "INSERT INTO varaus(mokki_mokki_id, asiakas_id, varattu_pvm, varattu_alkupvm, varattu_loppupvm) VALUES($mokki_id,$asiakas, $varattu_pvm, $varaus_alkupvm, $varaus_loppupvm)";

                        this.Lomake.Db.DMquery(query, pairs);
                        this.paivita();

                        Varaus vt = this.Lomake.Varaukset.Find(i => i.Asiakas.Asiakas_id == a.Asiakas_id && i.Mokki.Mokki_id == ((Mokki)this.CBMokki.SelectedItem).Mokki_id && i.Alkupvm_varaus == calVaraus.SelectionRange.Start && i.Loppupvm_varaus == calVaraus.SelectionRange.End);
                        string query2 = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES($varaus_id, $palvelu_id, $lkm)";
                        Dictionary<string, object> pairs2 = new Dictionary<string, object>();
                        foreach (VarauksenPalvelu pari in lbVarauksenPalvelut.Items)
                        {
                            summa += pari.lkm * (pari.p.Hinta+pari.p.Alv);
                            pairs2.Clear();
                            pairs2.Add("$varaus_id", vt.Varaus_id);
                            pairs2.Add("$palvelu_id", pari.p.Palvelu_id);
                            pairs2.Add("$lkm", pari.lkm);
                            this.Lomake.Db.DMquery(query2, pairs2);
                        }
                        if(calVaraus.SelectionRange.Start == calVaraus.SelectionRange.End)
                        {
                            days = 1;
                        } else
                        {
                            days = (calVaraus.SelectionRange.End - calVaraus.SelectionRange.Start).TotalDays;
                        }
                        summa += days * ((Mokki)this.CBMokki.SelectedItem).Hinta;
                 
                        query2 = "INSERT INTO lasku (varaus_id, summa, alv) VALUES ($varaus_id, $summa, $alv)";
                        pairs2.Clear();
                        pairs2.Add("$varaus_id", vt.Varaus_id);
                        pairs2.Add("$summa", summa);
                        pairs2.Add("$alv", (summa*1.24)-summa);
                        this.Lomake.Db.DMquery(query2, pairs2);

                        this.att.paivita();
                        this.Close();
                    } else
                    {
                        double summa = 0;
                        double days;
                        Dictionary<string, object> pairs2 = new Dictionary<string, object>();
                        pairs2.Add("$varaus_id", this.v.Varaus_id);
                        string query2 = "DELETE FROM varauksen_palvelut WHERE varaus_id = $varaus_id";
                        this.Lomake.Db.DMquery(query2, pairs2);

                        query = "UPDATE varaus SET varattu_alkupvm = $varattu_alkupvm, varattu_loppupvm = $varattu_loppupvm WHERE varaus_id=$varaus_id";
                        pairs2.Clear();
                        pairs2.Add("$varattu_alkupvm", calVaraus.SelectionRange.Start);
                        pairs2.Add("$varattu_loppupvm", calVaraus.SelectionRange.End);
                        pairs2.Add("$varaus_id", this.v.Varaus_id);
                        this.Lomake.Db.DMquery(query2, pairs);

                        query2 = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm) VALUES($varaus_id, $palvelu_id, $lkm)";
                        foreach (VarauksenPalvelu pari in lbVarauksenPalvelut.Items)
                        {
                            summa += pari.lkm * (pari.p.Hinta + pari.p.Alv);
                            pairs2.Clear();
                            pairs2.Add("$varaus_id", this.v.Varaus_id);
                            pairs2.Add("$palvelu_id", pari.p.Palvelu_id);
                            pairs2.Add("$lkm", pari.lkm);
                            this.Lomake.Db.DMquery(query2, pairs2);
                        }
                        if (calVaraus.SelectionRange.Start == calVaraus.SelectionRange.End)
                        {
                            days = 1;
                        }
                        else
                        {
                            days = (calVaraus.SelectionRange.End - calVaraus.SelectionRange.Start).TotalDays;
                        }
                        summa += days * ((Mokki)this.CBMokki.SelectedItem).Hinta;
                        Lasku l = this.Lomake.Laskut.Find(i => i.Varaus.Varaus_id == this.v.Varaus_id);
                        query2 = "UPDATE lasku SET summa=$summa, alv=$alv WHERE varaus_id = $varaus_id AND lasku_id=$lasku_id";
                        pairs2.Clear();
                        pairs2.Add("$lasku_id", l.Lasku_id);
                        pairs2.Add("$varaus_id", this.v.Varaus_id);
                        pairs2.Add("$summa", summa);
                        pairs2.Add("$alv", (summa * 1.24) - summa);
                        this.Lomake.Db.DMquery(query2, pairs2);
                        this.att.paivita();
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Mökillä on varauksia alkupäivän ja loppupäivän aikana.");
                }
            }
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {

            VarauksenPalvelu pari;
            if (cbPalvelut.SelectedIndex != -1)
            {
                if (nmrLukumaara.Value > 0) {
                    pari.p = (Palvelu)cbPalvelut.SelectedItem;
                    pari.lkm = int.Parse(nmrLukumaara.Value.ToString());
                    lbVarauksenPalvelut.Items.Add(pari);
                    cbPalvelut.Items.Remove(cbPalvelut.SelectedItem);
                }
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (lbVarauksenPalvelut.SelectedItems.Count > 0) {
                VarauksenPalvelu pari = (VarauksenPalvelu)lbVarauksenPalvelut.SelectedItem;
                cbPalvelut.Items.Add(pari.p);
                lbVarauksenPalvelut.Items.Remove(lbVarauksenPalvelut.SelectedItem);
            }
        }
        private Boolean MokkiVapaana()
        {
            List<Varaus> mokinvaraukset;
            if(this.v != null)
            {
                mokinvaraukset = this.Lomake.Varaukset.FindAll(i => i.Mokki.Mokki_id == ((Mokki)this.CBMokki.SelectedItem).Mokki_id && i.Varaus_id == this.v.Varaus_id);
            } else
            {
                mokinvaraukset = this.Lomake.Varaukset.FindAll(i => i.Mokki.Mokki_id == ((Mokki)this.CBMokki.SelectedItem).Mokki_id);
            }
            
            foreach(Varaus vm in mokinvaraukset)
            {
                if(calVaraus.SelectionRange.Start >= vm.Alkupvm_varaus && calVaraus.SelectionRange.Start <= vm.Loppupvm_varaus)
                {
                    return false;
                } else if (calVaraus.SelectionRange.End >= vm.Alkupvm_varaus && calVaraus.SelectionRange.End <= vm.Loppupvm_varaus)
                {
                    return false;
                }
            }
            return true;
        }

        private void cbToimintaalueet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbToimintaalueet.SelectedIndex != -1) {
                CBMokki.Items.Clear();
                List<Mokki> toimintamokit = this.Lomake.Mokit.FindAll(i => i.Toimintaalue.Toiminta_alueid == ((Toimintaalue)cbToimintaalueet.SelectedItem).Toiminta_alueid);
                foreach (Mokki m in toimintamokit) {
                    CBMokki.Items.Add(m);
                }
                cbPalvelut.Items.Clear();
                List<Palvelu> toimintapalvelut = this.Lomake.Palvelut.FindAll(i => i.Toimintaalue.Toiminta_alueid == ((Toimintaalue)cbToimintaalueet.SelectedItem).Toiminta_alueid);
                foreach (Palvelu pa in toimintapalvelut) {
                    cbPalvelut.Items.Add(pa);
                }
            }
        }
        private void btnMokintiedot_Click(object sender, EventArgs e)
        {
            if (CBMokki.SelectedIndex != -1)
            {
                Mokki m = (Mokki)CBMokki.SelectedItem;
                Mokkitiedot mt = new Mokkitiedot(this.Lomake, m);
                mt.Show();
            }
        }

        private void btnMokinhaku_Click(object sender, EventArgs e)
        {
            Mokinhaku mh = new Mokinhaku(this);
            mh.Show();
        }
        public void ValitseMokki(Mokki valittu)
        {
            cbToimintaalueet.SelectedItem = valittu.Toimintaalue;
            CBMokki.SelectedItem = valittu;
        }
    }
}