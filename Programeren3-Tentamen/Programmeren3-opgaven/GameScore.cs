using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class GameScore
    {
        public List<Score> Scores {get; private set;}
        public DateTime Datum { get; private set; }
        private string naam;
        public string Naam { get { return naam; } private set { naam = value; } }

        public int Waarde
        {
            get {
                int value = 0;
                foreach (Score item in Scores)
                {
                    value += item.BerekenWaarde();
                }
                return value;
            }
        }

        public GameScore(string naam, DateTime datum)
        {
            Scores = new List<Score>();
            Naam = naam;
            Datum = datum;
        }
    }
}
