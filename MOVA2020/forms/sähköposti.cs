using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;

namespace MOVA2020.forms
{
    /*
    * MOVA2020
    * Tekijä: Jonna Räsänen, Tommi Puurunen
    * 
    * Toteuttaa  toiminnallisuusmäärittelyn 
    *      3.3.1 Sähköinen lasku
    * 
    */
    public partial class sähkoposti : Form
    {
        private Attachment file;
 
        public sähkoposti(string filename)
        {
            InitializeComponent();
            this.file = new Attachment(filename);
        }
        /* Käyttäjä syöttää sähköpostin, jolla lasku lähetetään asiakkaalle. Vastaanottajan sähköpostiksi
         * on kovakoodattu testisähköposti, testaamisen helpottamiseksi. Lähettäjäsähköpostin on oltava gmail-osoite.
         */
        private void btkirjaudu_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(tbosoite.Text);
                message.To.Add(new MailAddress("jonna.rasanen@edu.savonia.fi"));
                message.Subject = "VillageNewbies mökkivaraus";
                message.IsBodyHtml = true;
                message.Body = "Tämä on automaattinen viesti";
                message.Attachments.Add(file);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(tbosoite.Text, tbsalasana.Text);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("Sähköposti lähetetty", "", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception) {
                MessageBox.Show("Sähköposti tai salasana väärin", "Jotain meni pieleen", MessageBoxButtons.OK);
            }
            
        }
    }
}
