using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Silnik : IInformacje
    {
        public long LiczbaPrzejechanychKilometrow { get; private set; }
        public long PojemnoscSilnika { get; private set; }

        //tutaj jak zwykle powinny znaleźć się odpowiednie konstruktory - silnik musi mieć pojemność i jakąś startową wartość kilometrów

        public virtual void WyswietlInformacje() {...};
        //ta metoda wyświetli informację o instancji silnika

        public virtual long JedziemyWSinaDal(long liczbaKilometrow, ZbiornikPaliwa zbiornikPaliwa) {...};
        /*	
        metoda powinna pozwolić na przejechanie liczby kilometrów, na która pozwala ilość paliwa w zbiorniku - nie wiecej,
        dodatkowo liczba przejechanych kilometrow powinna byc podbijana
        funkcja jako wartosc powrotna przekazuje liczbe autentycznie przejechanych kilometrow
        do obliczenia zużycia paliwa proszę wykorzystać pole PojemnoscSilnika - oczywiście chodzi tu o jakis prosty wzór - nie chcemy, bawić się w inżynierów mechaników :D
        */

        public abstract string TypSilnika() {...};
        //metoda musi być przysłonieta po stronie klasy dziedziczącej - jej zadaniem jest przekazanie nazwy typu silnika	
    }

    /*
        następnie dziedzicząc z klasy podstawowej powinniśmy stworzyć kilka klas reprezentujących konkretne silniki, czyli benzynowy, Diesela, Wankla, parowy, etc. :P z odpowiednimi pojemnościami, etc.	

        Mając już silniki, możemy przejść do tworzenia klasy pojazdu - zakladamy, że nie musi to być koniecznie samochód, a np. kombajn - jednym słowem idziemy w uniwersalność.
    */
}
