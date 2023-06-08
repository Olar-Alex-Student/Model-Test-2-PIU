using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Test_2._2_PIU
{
    class Medicament
    {
        public string Denumire { get; set; }
        public int NrUnitati { get; set; }
        public List<string> Afectiuni { get; set; }
        public DateTime DataExpirare { get; set; }
        public string FormaPrezentare { get; set; }
        public Medicament() { }
        public Medicament(string denumire, int nrUnit, List<string> afectiuni, DateTime dataExp, string
        formaPrezentare)
        {
            Denumire = denumire;
            NrUnitati = nrUnit;
            Afectiuni = new List<string>();
            Afectiuni.AddRange(afectiuni);
            DataExpirare = dataExp;
            FormaPrezentare = formaPrezentare;
        }
        public override string ToString()
        {
            string strAfectiuni = "Nici o afectiune";
            if (Afectiuni != null && Afectiuni.Any())
            {
                strAfectiuni = String.Join(",", Afectiuni.ToArray());
            }
            return string.Format("{0}, Afectiuni: {1}, NrUnitati: {2}, DataExpirare: {3}, FormaPrezentare:{4}", Denumire, strAfectiuni, NrUnitati, DataExpirare.ToShortDateString(), FormaPrezentare);
        }
    }
}
