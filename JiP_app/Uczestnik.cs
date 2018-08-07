using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiP_app
{
    public class Uczestnik
    {
        private string Imie;
        private string Nazwisko;
        private string Miasto;
        private Decimal LiczbaJU;

        public Uczestnik()
        {

        }
        
        public Uczestnik(string Imie, string Nazwisko, string Miasto, Decimal LiczbaJU)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Miasto = Miasto;
            this.LiczbaJU = LiczbaJU;
        }

        public string getImie()
        {
            return this.Imie;
        }

        public string getNazwisko()
        {
            return this.Nazwisko;
        }

        public string getMiasto()
        {
            return this.Miasto;
        }

        public Decimal getLiczbaJU()
        {
            return this.LiczbaJU;
        }
    }
}
