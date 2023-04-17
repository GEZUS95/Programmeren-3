using System;
using System.Collections.Generic;

namespace Programmeren3_opgaven
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            //Opgave1();
            //Opgave2();
            //Opgave3();
            Opgave5();

            Console.ReadKey();
        }

        void Opgave1()
        {
            Console.WriteLine(new Score(6, 500).ToString());
        }

        void Opgave2()
        {
            List<Score> list = new List<Score>();

            list.Add(new Score(3, 600));
            list.Add(new BonusScore(7, 500, 8));
            list.Add(new Score(6, 750));
            list.Add(new BonusScore(4, 240, 6));

            foreach (Score item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        void Opgave3()
        {
            GameScore gameScore = new GameScore("Cees", DateTime.Now);
            gameScore.Scores.Add(new Score(1, 20));
            gameScore.Scores.Add(new Score(2, 40));
            gameScore.Scores.Add(new BonusScore(3, 50, 9));

            foreach (Score item in gameScore.Scores)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"GameScore value: {gameScore.Waarde}");
        }

        void Opgave5()
        {
            Zak zak = new Zak(15);
            zak.Voegtoe(new Edelsteen(1, 12));
            zak.Voegtoe(new Edelsteen(1, 30));
            zak.Voegtoe(new Wapen(3, WapenSoort.Bijl));

        }
    }
}
