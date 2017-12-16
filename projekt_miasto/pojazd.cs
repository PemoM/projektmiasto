using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Pojazd : IInformacje
    {
        public enum RodzajPojazdu
        {
            JEDNOSLAD = 0x0001,
            OSOBOWY = 0x0002,
            TERENOWY = 0x0003,
            CIEZAROWY = 0x0004
        };

        public ZbiornikPaliwa ZbiornikPaliwa { get; private set; }
        public Silnik Silnik { get; private set; }
        public RodzajPojazdu Rodzaj { get; private set; }


        //tutaj jak zwykle powinny znaleźć się odpowiednie konstruktory - proszę zbudować je sprytnie, pytanie czy tutaj musimy już inicjować obiekty ZbiornikPaliwa i Silnik, czy zrobić to np. w klasach potomnych

        public virtual void WyswietlInformacje() {...};
        //ta metoda wyświetli informację o pojezdzie

        public abstract string Marka() {...};
        public abstract string Model() {...};

        public virtual long JedziemyWSinaDal(long liczbaKilometrow);
        //metoda powinna odwołać się do obiektu Silnik i odpowiednio na nim zadziałać by przejechać zadaną liczbę kilometrów
    }

}
