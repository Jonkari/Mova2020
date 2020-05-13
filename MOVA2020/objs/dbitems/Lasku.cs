using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Lasku
    {
        private long lasku_id;
        private Varaus varaus;
        private double summa, alv;

        public Lasku(long lasku_id, double summa, double alv, Varaus varaus)
        {
            this.lasku_id = lasku_id;
            SummaEiAlv = summa;
            Alv = alv;
            Varaus = varaus;
        }

        public long Lasku_id { get => lasku_id; }
        public Asiakas Varaaja { get => this.varaus.Asiakas; }
        public DateTime Erapaiva { get => Varaus.Varattu_pvm.AddDays(14); }
        public double SummaEiAlv { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }
        public double Summa { get => alv + summa; }
        public Varaus Varaus { get => varaus; set => varaus = value; }
    }
}
