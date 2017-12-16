using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class ZbiornikPaliwa : IInformacje
    {
        public long MaksymalnaIloscPaliwa { get; private set; }
        public long IloscPaliwa { get; private set; }

        //tutaj klasycznie odpowiedni konstruktor

        public void Dotankuj(long iloscPaliwa);
        public long Pobierz(long iloscPaliwa);
        //każda z powyżych metod musi być odpowiednio zabezpieczona, np. nie można dodatnkować wartości ujemnej
    }

}
