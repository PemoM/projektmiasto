using System;

namespace projekt_miasto.Zwierzatka
{
    public abstract class Zwierzatko : IInformacje
    {
        public enum RodzajZwierzatka
        {
            DOMOWE = 0x0001,
            HODOWLANE = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        public string Imie { get; private set; }
        public int Wiek { get; private set; }

        public RodzajZwierzatka Rodzaj { get; set; }

        public Zwierzatko ()
        {
            this.UstawDane(Toolbox.BRAK_DANYCH, 0, RodzajZwierzatka.BRAK_DANYCH);
        }

        public Zwierzatko (string imie, int wiek, RodzajZwierzatka rodzaj)
        {
            this.UstawDane(imie, wiek, rodzaj);
        }

        public void UstawDane(string imie, int wiek, RodzajZwierzatka rodzaj)
        {
            SprawdzDane(imie, wiek);
            this.Imie = imie;
            this.Wiek = wiek;
            this.Rodzaj = rodzaj;
        }

        private void SprawdzDane(string imie, int wiek)
        {
            if (string.IsNullOrEmpty(imie))
            {
                throw new ArgumentException("Nie podano imienia");
            }
            if (wiek < 0)
            {
                throw new ArgumentException("Wiek nie może być ujemny!");
            }
        }

        public abstract string GatunekZwierzatka();
        public abstract string RasaZwierzaka();
        public abstract void NiechZwierzCosPowie();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Imie = {0} Wiek = {1} Rodzaj = {2}", this.Imie, this.Wiek, this.Rodzaj.ToString());
        }
    }
}