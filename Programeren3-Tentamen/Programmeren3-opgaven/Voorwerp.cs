using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public abstract class Voorwerp
    {
        public int Gewicht { get; private set; }

        public Voorwerp(int gewicht)
        {
            Gewicht = gewicht;
        }
    }

    public class Edelsteen : Voorwerp
    {
        public int Waarde { get; set; }

        public Edelsteen(int gewicht, int waarde) : base(gewicht)
        {
            Waarde = waarde;
        }
    }

    public class Voedsel : Voorwerp
    {
        public int Calorieen { get; set; }

        public Voedsel(int gewicht, int calorieen) : base(gewicht)
        {
            Calorieen = calorieen;
        }
    }

    public class Wapen : Voorwerp
    {
        public WapenSoort wapensoort;

        public Wapen(int gewicht, WapenSoort ws) : base(gewicht)
        {
            wapensoort = ws;
        }
    }

    public enum WapenSoort
    {
        Zwaard, Bijl, Kruisboog,Dolk
    }

    public class Inventaris
    {
        public List<Voorwerp> inhoud;
        public Inventaris()
        {
            inhoud = new List<Voorwerp>();
        }
    }

    public class Speler
    {
        public Inventaris inventaris = new Inventaris();
    }
}
