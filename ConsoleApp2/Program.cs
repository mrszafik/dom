using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            dom dom1 = new dom("kwiatowa", 35, "Jadwiga", 5);
            dom dom2 = new dom("takowa", 140, "Jan, Malgorzata, Jacek", 20);

            Console.WriteLine("Ulica: " + dom1.adres + " Metraz: " + dom1.metraz + " Domownicy: " + dom1.domownicy
                + " Ilosc okien: " + dom1.liczbaOkien + " Podatek: " + dom1.countTaxes());
            Console.WriteLine("Ulica: " + dom2.adres + " Metraz: " + dom2.metraz + " Domownicy: " + dom2.domownicy
                + " Ilosc okien: " + dom2.liczbaOkien + " Podatek: " + dom2.countTaxes());

            Console.ReadKey();
        }
    }
}
