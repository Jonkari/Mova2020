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
