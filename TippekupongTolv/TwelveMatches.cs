using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TippekupongTolv
{
    internal class TwelveMatches
    {
        private Match[] _matches;
        private string[] _bets;
        
        public TwelveMatches() 
        {
            _matches = new Match[12];
            _bets = new string[12];

            for (int i = 0; i < _matches.Length; i++)
            {
                _matches[i] = new Match();
            }
        }
        public void PlayMatches()
        {
            foreach(var match in _matches)
            {
                match.StartMatch();
            }
        }
        public void SetBets()
        {


            for(int i = 0; i < _bets.Length; i++)
            {
                Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for kamp nr" + (i+1) + "? ");
                string? currentBet = Console.ReadLine();
                _bets[i] = currentBet == null ? "U" : currentBet;

            }

        }

        private bool[] GetBettingResultsArray()
        {
            bool[] bettingResults = new bool[12];
            //int countCorrects = 0;
            for (int i = 0; i < _matches.Length; i++)
            {
                bettingResults[i] = _bets[i].Contains(_matches[i].Result())? true : false;
                //Console.WriteLine(bettingResults[i] == true? "Riktig" : "Feil");
                
            }
            return bettingResults;
        }

        private int GetNumberOfCorrectBets()
        {
            bool[] bettingResults = GetBettingResultsArray();
            int count = 0;
            for (int i = 0; i < bettingResults.Length; i++)
            {
                if(bettingResults[i] == true) count++;
                
            }
            return count;

        }

        public void PrintResults()
        {
            bool[] bettingResults = GetBettingResultsArray();
            int correctBets = GetNumberOfCorrectBets();

            Console.WriteLine("Resultater:");
            for (int i = 0; i < _matches.Length; i++)
            {
                Console.Write(_matches[i].GetScore() + " " +_matches[i].Result());
                Console.Write(" " + (bettingResults[i] == true ? "Riktig" : "Feil") + "\n");
            }
            Console.WriteLine($"Du hadde {correctBets} av 12 riktige");
        }
    }
}
