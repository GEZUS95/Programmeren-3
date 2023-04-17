using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public class Score
    {
        protected int Level { get; set; }
        protected int Punten { get; set; }

        public Score(int level, int punten)
        {
            Level = level;
            Punten = punten;
        }

        public virtual int BerekenWaarde()
        {
            return Level * Punten;
        }

        public override string ToString()
        {
            return $"Score of level {Level}: value = {BerekenWaarde()}, points: {Punten}";
        }
    }
}
