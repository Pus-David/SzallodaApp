using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int Szobaszam { get; set; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value <= 0)
                {
                    alapar = 1;
                }
                alapar = value;
            }
        }
        public Szoba (int szobaszam, int alapar)
        {
            Szobaszam = szobaszam;
            Alapar = this.alapar;
        }

        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }
        public override string ToString()
        {
            return $"Szoba {Szobaszam}  Alapár:  {Alapar}  Ft / éj"; 
        }
    }
}
