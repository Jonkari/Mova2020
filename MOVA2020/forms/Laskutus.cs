using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020.objs.dbitems;
using System.Drawing.Printing;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;
using System.Drawing.Imaging;

namespace MOVA2020.forms
{
    /*
    * MOVA2020
    * Tekijä: Jonna Räsänen, Tommi Puurunen
    * 
    * Toteuttaa  toiminnallisuusmäärittelyn 
    *      3.3.1 Sähköinen lasku
    *      3.3.2 Paperinen lasku
    *      4.2.2 Varmistus laskun maksusta
    * 
    */
    public partial class Laskutus : Form
    {
        private Lasku l;
        private Primary p;
        Bitmap bitmap;

        // 3.3 Laskutuksen koodi. Laskuun ilmestyy automaattisesti asiakkaan tiedot valitusta varauksesta
        public Laskutus(Primary p, Lasku l)
        {
            InitializeComponent();
            this.p = p;
            this.l = l;
            if(this.l.Varaus.Vahvistus_pvm.Equals(DateTime.Parse("1970-01-01 00:00:00")))
            {
                btnVarmenna.Enabled = true;
            }
            TByht.Text = l.Summa.ToString();
            TBAsiakas.Text = l.Varaus.Asiakas.ToString();
            TBnum.Text = l.Lasku_id.ToString();
            TBerapvm.Text = l.Erapaiva.ToString("dd-MM-yyyy");
            TBpvm.Text = DateTime.Now.ToString("dd-MM-yyyy");
            string lisatiedot = l.Varaus.Mokki.Kuvaus + "\r\n" + l.Varaus.Mokki.Varustelu + "\r\n";
            string summat = l.Varaus.Alkupvm_varaus.ToString("yyyy-MM-dd")+" - "+l.Varaus.Loppupvm_varaus.ToString("yyyy-MM-dd")+ "\r\n";
            if (l.Varaus.Alkupvm_varaus == l.Varaus.Loppupvm_varaus)
            {
                summat += 1 + " päivä(ä), " + l.Varaus.Mokki.Hinta * 1 + "€";
            }
            else
            {
                summat += (l.Varaus.Loppupvm_varaus - l.Varaus.Alkupvm_varaus).TotalDays.ToString() + " päivä(ä), " +
                l.Varaus.Mokki.Hinta * (l.Varaus.Loppupvm_varaus - l.Varaus.Alkupvm_varaus).TotalDays + "€";
            }

            foreach (KeyValuePair<int, int> item in l.Varaus.Varauksenpalvelut)
            {
                Palvelu pa = this.p.Palvelut.Find(i => i.Palvelu_id == item.Key);
                lisatiedot += "\r\n" + pa.Nimi + pa.Hinta.ToString() + " €/kpl\r\nx" + item.Value;
                summat += "\r\nx" + item.Value +" * " + pa.Hinta.ToString() + "€" + " = "+(item.Value * pa.Hinta) + "€";
            }
            TBlisatiedot.Text = lisatiedot;
            summat += "\r\nSumma (ilman ALV):" + l.SummaEiAlv + "€";
            summat += "\r\nALV (24%):" + l.Alv + "€";
            TBLaskutus.Text = summat;
        }

        /*3.3.2. Paperinen lasku. Piirtää täytetyn laskuformin ja avaa tulostuksen esikatselun,
         *jota kautta laskun saa tulostettua
         */
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, e.MarginBounds);
        }
        private void bttulosta_Click(object sender, EventArgs e)
        {
            Graphics grp = CreateGraphics();
            Size formSize = this.panelLasku.Size;
            bitmap = new Bitmap(formSize.Width, formSize.Height);
            panelLasku.DrawToBitmap(bitmap, new Rectangle(0, 0, formSize.Width, formSize.Height));
            grp = Graphics.FromImage(bitmap);
      
            printpreview.Document = printDocument;
            printpreview.ClientSize = bitmap.Size;
            printpreview.PrintPreviewControl.Zoom = 1;
            printpreview.ShowDialog();
        }
        /* 3.3.1 Sähköinen lasku. Luo laskusta kuvatiedoston, joka lähetetään asiakkaan sähköpostiin.
         * Avaa formin, jolle käyttäjä laittaa oman/yrityksensä sähköpostin. Kuva laskusta tallennetaan myös
         * käyttäjän tietokoneelle.
         */
        private void btlaheta_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\MOVA2020";
            System.IO.Directory.CreateDirectory(path);
            string filename = (DateTime.Now).ToString("yyyy-MM-dd") + "_" + this.l.Varaus.Varaus_id.ToString()+"_"+Path.GetRandomFileName()+".png";
            string fullpath = path + @"\" + filename;

            Graphics grp = CreateGraphics();
            Size formSize = this.panelLasku.Size;
            bitmap = new Bitmap(formSize.Width, formSize.Height);
            panelLasku.DrawToBitmap(bitmap, new Rectangle(0, 0, formSize.Width, formSize.Height)) ;
            bitmap.Save(fullpath, ImageFormat.Png);

            Sahkoposti sp = new Sahkoposti(path+@"\"+filename, this.l.Varaus.Asiakas, true);
            sp.Show();
        }

        private void btnVaraustiedot_Click(object sender, EventArgs e)
        {
            Varauksentiedot vt = new Varauksentiedot(p, l.Varaus);
            vt.Show();
        }

        //4.2.2-4.2.3 Napilla varmennetaan, että lasku on maksettu.
        private void btnVarmenna_Click(object sender, EventArgs e)
        {
            Varaus var = this.l.Varaus;
            DialogResult dr = MessageBox.Show("Onko kyseinen maksu suoritettu ?", "Maksun varmennus", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("$vahvistus_pvm", DateTime.Now);
                pairs.Add("$varaus_id", var.Varaus_id);
                string query = "UPDATE varaus SET vahvistus_pvm=$vahvistus_pvm WHERE varaus_id=$varaus_id";
                this.p.Db.DMquery(query, pairs);
                MessageBox.Show("Maksu on merkattu suoritetuksi!", "Maksun varmennus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVarmenna.Enabled = false;
                this.p.paivita();
            }
        }

    }
}
