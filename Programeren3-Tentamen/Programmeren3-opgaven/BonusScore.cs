using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class BonusScore : Score
    {
        protected int Bonus { get; set; }

        public BonusScore(int level, int score, int bonus) : base(level, score)
        {
            Bonus = bonus;
        }

        public override int BerekenWaarde()
        {
            return base.BerekenWaarde() + (Bonus * 10); 
        }

        public override string ToString()
        {
            return $"{base.ToString()}, bonus: {Bonus}";
        }
    }
}
