namespace TippekupongTolv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwelveMatches twelveMatches = new TwelveMatches();
            twelveMatches.SetBets();
            twelveMatches.PlayMatches();
            twelveMatches.PrintResults();


        }
    }
}