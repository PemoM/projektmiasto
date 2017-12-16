using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using projekt_miasto.Zwierzatka;
using projekt_miasto.Zwierzatka.Kot;
using projekt_miasto.Zwierzatka.Pies;

namespace projekt_miasto
{
    class Program
    {
        static void Main(string[] args)
        {//sprawdzam GITA
            /*
            Miasto miasto = new Miasto();
            miasto.uzupelnijMiasto();
            miasto.wyswietlDaneOsob();            
            Console.ReadKey();
            */


            List<IInformacje> ListaInformacji = new List<IInformacje>();


            var zwierzyniec = Zwierzyniec.Instancja();
            
            zwierzyniec.DodajZwierzatko(new Beagle());
            zwierzyniec.DodajZwierzatko(new Labrador());
            zwierzyniec.DodajZwierzatko(new York());
            
            zwierzyniec.DodajZwierzatko(new Perski());
            zwierzyniec.DodajZwierzatko(new Syjamski());
            zwierzyniec.DodajZwierzatko(new BrytyjskiKrolewski());
            
            zwierzyniec.DodajZwierzatko(new Kot());
            zwierzyniec.DodajZwierzatko(new Pies());

            Zwierzatko zwierz = zwierzyniec.PobierzZwierzatko(0);
            while (zwierz != null)
            {
                Console.WriteLine(zwierz.RasaZwierzaka());
                Console.WriteLine(zwierz.GatunekZwierzatka());
                zwierz.NiechZwierzCosPowie();
                zwierz = zwierzyniec.PobierzZwierzatko(0);
            }
            
            ListaInformacji.Add(new Osoba("Jacek", "Kuźmicz"));
            ListaInformacji.Add(new Adres("", "", "", 5));

            for (int i = 0; i < ListaInformacji.Count; ++i)
                ListaInformacji[i].WyswietlInformacje();
            Console.ReadLine();
        }
    }
}
