using System;

namespace projekt_miasto.Zwierzatka.Kot
{
    public class Kot : Zwierzatko
    {
        public Kot() : base()
        {
        }

        public Kot(string imie, int wiek, RodzajZwierzatka rodzaj) : base(imie, wiek, rodzaj)
        {
        }

        public override string GatunekZwierzatka()
        {
            return nameof(Kot);
        }

        public override string RasaZwierzaka()
        {
            return this.GetType().Name;
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Miau, miau!");
        }
    }
}