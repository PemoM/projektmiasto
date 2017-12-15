using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt_miasto.Zwierzatka;

namespace projekt_miasto
{
    class Osoba : IInformacje
    {
        public enum RodzajPlci
        {
            MEZCZYZNA = 0x0001,
            KOBIETA = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public RodzajPlci Plec { get; private set; }
        public Adres Adres { get; private set; }
        public string AdresEmail { get; private set; } //dodane
        /* tutaj powinny znaleźć sie odpowiednie konstruktory
		zakladamy, ze płeć jest niezmienna - zatem wydaje się, że jeden z pierwszych konstruktorów powinien jako argument przyjmować własnie płeć  */

        private List<Zwierzatko> o_listaZwierzatek; //lista zwierzątek

        public Osoba()
        {
            o_listaZwierzatek = new List<Zwierzatko>(); //zwierzątko
            this.Plec = RodzajPlci.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH);
            this.Adres = new Adres();
        } 
        //dołożyć konstrukotr

        public Osoba(string imie, string nazwisko) : this()
        {
            this.UstawDane(imie, nazwisko);
        }
        /* metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
        dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych

        sprawdzanei poprawności dla adresu email proszę zaimplementować w klasie toolbox */
        public void UstawDane(string imie, string nazwisko) //dodać
        {
            if (!string.IsNullOrEmpty(imie))
                this.Imie = imie;

            if (!string.IsNullOrEmpty(nazwisko))
                this.Nazwisko = nazwisko;
        }

        public static Osoba StworzOsobe()            
        {
            Osoba result = new Osoba();

            Console.WriteLine("=== wprowadz dane nowej osoby ===");

            result.UstawDane(Toolbox.inputString("Podaj imie:", true),
                Toolbox.inputString("Podaj nazwisko:", false));

            result.Adres.UstawDane(Toolbox.inputString("Podaj ulice:", false),
                Toolbox.inputString("Podaj miasto:", false),
                Toolbox.inputString("Podaj kod pocztowy:", false),
                Toolbox.inputInteger("Podaj nr domu:", 1, int.MaxValue));

            return result;
        }

        public void AdoptujZwierza(Zwierzatko o_zwierzatko) //adoptuj zwierzątko
        {
            this.o_listaZwierzatek.Add(o_zwierzatko);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Imie = {0} Nazwisko = {1}", this.Imie, this.Nazwisko);
            this.Adres.WyswietlInformacje();
        }
    }
}