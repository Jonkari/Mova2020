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
using MOVA2020;
namespace MOVA2020.forms
{
    /*
     * Tehnyt: Tommi Puurunen
     * 
     * Näyttää varauksen tiedot
     * 
     */

    public partial class Varauksentiedot : Form
    {
        private struct VarauksenPalvelu
        {
            Palvelu palvelu;
            int lukumaara;

            public Palvelu Palvelu { set => palvelu = value; }

            public string Nimi { get => this.palvelu.Nimi; }
            public string Kuvaus { get => this.palvelu.Kuvaus; }
            public double Hinta { get => this.palvelu.Hinta; }
            public int Lukumaara { get => lukumaara; set => lukumaara = value; }
        }
        private Varaus varaus;
        private Primary p;
        
        public Varauksentiedot(Primary p, Varaus v)
        {
            this.varaus = v;
            this.p = p;
            InitializeComponent();

            tbAsiakasnimi.Text = v.Asiakas.Etunimi + " " + v.Asiakas.Sukunimi;
            tbMokkinimi.Text = v.Mokki.Mokkinimi;
            dtpVarattupvm.Value = v.Varattu_pvm;
            calVaraus.SelectionStart = v.Alkupvm_varaus;
            calVaraus.SelectionEnd = v.Loppupvm_varaus;
            dgvPalvelut.DataSource = null;
            List<VarauksenPalvelu> vp = new List<VarauksenPalvelu>();
            foreach(KeyValuePair<int, int> item in v.Varauksenpalvelut)
            {
                VarauksenPalvelu vpp = new VarauksenPalvelu();
                vpp.Palvelu = this.p.Palvelut.Find(i => i.Palvelu_id == item.Key);
                vpp.Lukumaara = item.Value;
                vp.Add(vpp);
            }
            dgvPalvelut.DataSource = vp;
        }

        private void btnAsiakkaantiedot_Click(object sender, EventArgs e)
        {
            Asiakastiedot at = new Asiakastiedot(this.p, this.varaus.Asiakas);
            at.Show();
        }

        private void btnMokintiedot_Click(object sender, EventArgs e)
        {
            Mokkitiedot mt = new Mokkitiedot(this.p, this.varaus.Mokki);
            mt.Show();
        }
    }
}
