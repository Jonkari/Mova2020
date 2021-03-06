using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Asiakas
    {
        private Posti posti;
        private long asiakas_id;
        private string etunimi, sukunimi, lahiosoite, email, puhelinnro;

        public Asiakas(long asiakas_id, string etunimi, string sukunimi, string lahiosoite, string email, string puhelinnro, Posti posti)
        {
            this.asiakas_id = asiakas_id;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Lahiosoite = lahiosoite;
            Email = email;
            Puhelinnro = puhelinnro;
            Posti = posti;
        }

        public long Asiakas_id { get => asiakas_id;}
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Lahiosoite { get => lahiosoite; set => lahiosoite = value; }
        public string Email { get => email; set => email = value; }
        public string Puhelinnro { get => puhelinnro; set => puhelinnro = value; }
        public Posti Posti { get => this.posti; set => this.posti = value; }

        override
        public string ToString()
        {
            return this.etunimi + " " + this.sukunimi;
        }
    }
}
