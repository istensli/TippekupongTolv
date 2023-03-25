using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippekupongTolv
{
    internal class Match
    {
        int HomeGoals { get; set; }
        int AwayGoals { get; set; }
        bool MatchIsRunning { get; set; }

        int Minutes { get; set; }

        public Match()
        {
            HomeGoals = 0;
            AwayGoals = 0;
            MatchIsRunning = false;
            Minutes = 0;
        }

        public void StartMatch()
        {
            Random rnd = new Random();

            MatchIsRunning = true;

            while (MatchIsRunning)
            {
                int num = rnd.Next(0, 10);
                if (num == 1) HomeGoal();
                else if (num == 2) AwayGoal();

                //PrintStandings();
                //PrintMinutes();
                //Thread.Sleep(500);
                Minutes += 5;
                if (Minutes > 90) MatchIsRunning = false;

            }


        }

        private void AwayGoal()
        {
            AwayGoals += 1;
            //Console.WriteLine("Bortelaget scorer!");
            //PrintStandings();
        }

        private void HomeGoal()
        {
            HomeGoals += 1;
            //Console.WriteLine("Hjemmelaget scorer!");
            //PrintStandings();
        }

        private void PrintStandings()
        {
            Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}.");
        }
        private void PrintMinutes()
        {
            Console.WriteLine($"-----------Minutes passed: {Minutes} -------------");
        }

        public string Result()
        {
            return HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";

        }
        public string GetScore()
        {
            return $"{HomeGoals} - {AwayGoals}";

        }


    }
}
