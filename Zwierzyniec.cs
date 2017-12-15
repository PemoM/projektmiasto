using System;
using System.Collections.Generic;
using projekt_miasto.Zwierzatka;

namespace projekt_miasto
{
    class Zwierzyniec : IInformacje
    {
        private static Zwierzyniec o_instancja;	
        private List<Zwierzatko> o_listaZwierzatek ;
        //tutaj powinny znaleźć sie odpowiedni konstruktor
        private Zwierzyniec()
	    {
		    o_listaZwierzatek = new List<Zwierzatko>();
	    }

	    public static Zwierzyniec Instancja()
        //statyczna funkcja, ktora powinna w odpowiedni sposob (jeśli to wymagane) zainicjować instancję klasy Zwierzyniec/lub zwrócić już zainicjowaną
        {
            if (o_instancja == null)
		    {
			    o_instancja = new Zwierzyniec();
		    }
		    return o_instancja;
	    }

	    public void DodajZwierzatko(Zwierzatko o_zwierzatko)
        //metoda dodaje zwierzaka przekazanego jako argument 
        {
            this.o_listaZwierzatek.Add(o_zwierzatko);
	    }

	    public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka) //pobieramy zwierzaka z listy - jednoczesnie go z niej usuwajac - metoda powinna być "odporna" na błędy	
        {
		    if (i_indeksZwierzatka >= o_listaZwierzatek.Count || i_indeksZwierzatka < 0)
		    {
			    return null;
			    // Lepiej rzucić wyjątek.
			    //throw new ArgumentException("Nie ma tylu zwierzątek.");
		    }
		    Zwierzatko zwierzatko =  o_listaZwierzatek[i_indeksZwierzatka];
		    o_listaZwierzatek.RemoveAt(i_indeksZwierzatka);
		    return zwierzatko;
	    }

	    public void WyswietlInformacje() //ta metoda wyświetli listę dostępnych zwierzaków z informacją o indeksie, pod którym zwierzak występuje
        {
		    for (int i = 0; i < o_listaZwierzatek.Count; i++)
		    {
			    Console.WriteLine("Zwierzatko numer:{0}", i);
			    o_listaZwierzatek[i].WyswietlInformacje();
		    }
	    }
    }
}