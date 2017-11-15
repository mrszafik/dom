using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class dom
    {
        public string adres;
        public int metraz;
        public string domownicy;
        public int liczbaOkien;

        public dom(string adres, int metraz, string domownicy, int liczbaOkien)
        {
            this.adres = adres;
            this.metraz = metraz;
            this.liczbaOkien = liczbaOkien;
            this.domownicy = domownicy;
        }

        public int countTaxes()
        {
            return 10 * metraz;
        }
    }
}
