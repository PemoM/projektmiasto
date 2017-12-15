using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Adres : IInformacje
    { 
        public string Ulica { get; private set; }
        public string Miasto { get; private set; }
        public string KodPocztowy { get; private set; }
        public int NrDomu { get; private set; }

        //tutaj powinny znaleźć sie odpowiednie konstruktory
        public Adres ()
        {
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, 0);
        }

        public Adres (string ulica, string miasto, string kodPocztowy, int nrDomu) : this()
        {
            this.UstawDane(ulica, miasto, kodPocztowy, nrDomu);
        }

        public void UstawDane(string ulica, string miasto, string kodPocztowy, int nrDomu)
        /* metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
    dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych
    sprawdzanie poprawności dla kodu pocztowego proszę zaimplementować w klasie toolbox */
    // Po co przeciążać
        {
            this.Ulica = ulica;
            this.Miasto = miasto;
            this.KodPocztowy = kodPocztowy;
            this.NrDomu = nrDomu;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("{0} {1}\n{2} {3}", this.Ulica, this.NrDomu, this.KodPocztowy, this.Miasto);
        }
    }
}
