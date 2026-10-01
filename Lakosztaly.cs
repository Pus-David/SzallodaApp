using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }


        public Lakosztaly : Szoba (int szobaszam, int alapar, int extraszolgaltatas)
        {
            base.Szobaszam = szobaszam;
            base.Alapar = alapar;
            ExtraSzolgaltatasAr = extraszolgaltatas;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            return ExtraSzolgaltatasAr + base.ArKiszamitas(int ejszakakSzama);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Extra szolgáltatás: {ExtraSzolgaltatasAr}";
        }
    }
}
