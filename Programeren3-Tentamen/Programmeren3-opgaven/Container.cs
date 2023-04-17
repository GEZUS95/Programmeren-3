using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3_opgaven
{
    public abstract class Container
    {
        private int maxGewicht;
        public Container(int gewicht)
        {
            maxGewicht = gewicht;
        }

        public Inventaris inhoud = new Inventaris();

        public void Voegtoe(Voorwerp vw)
        {
            inhoud.inhoud.Add(vw);
        }

        public int BerekenGewicht()
        {
            int totGewicht = 0;
            foreach (Voorwerp item in inhoud.inhoud)
            {
                totGewicht += item.Gewicht;
            }
            return totGewicht;
        }
    }

    public class Zak : Container
    {
        public Zak(int gewicht) : base(gewicht)
        {

        }
    }
    
    public class Kist : Container
    {
        public Kist(int gewicht) : base(gewicht)
        {

        }
    }
}
