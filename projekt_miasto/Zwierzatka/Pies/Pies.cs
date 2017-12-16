using System;

namespace projekt_miasto.Zwierzatka.Pies
{
    public class Pies : Zwierzatko
    {
        public Pies() : base()
        {
        }

        public Pies(string imie, int wiek, RodzajZwierzatka rodzaj) : base(imie, wiek, rodzaj)
        {
        }

        public override string GatunekZwierzatka()
        {
            return nameof(Pies);
        }

        public override string RasaZwierzaka()
        {
            return this.GetType().Name;
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Woof, woof!");
        }
    }
}