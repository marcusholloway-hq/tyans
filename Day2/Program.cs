using Day2.Core;
using Day2.Core.Tyans;
using Day2.Core.Tyans.Settings;
using System;
using System.IO;

namespace Day2
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            #region Generate

            // array of tyan names
            string[] names = File.ReadAllText("Resources/TyanNames.txt").Split(' ');

            var tyanFactory = new TyanFactory(new FactorySettings(names, 200));

            // ReadOnlyCollection with generated tyans
            var tyans = tyanFactory.Generate();

            // output all generated tyans
            Console.WriteLine("\n===== GENERATED TYANS =====\n"); 
            
            foreach (var tyan in tyans)
            {
                // ToString() is overrided to output all tyan params
                Console.WriteLine($"-> {tyan}");
            }

            #endregion

            #region Search

            // basic searcher settings
            var tyanSearcherSettings = new SearcherSettings<Tyan>(tyans);

            // tyan searcher. SearcherSettings instance transmits collection of tyans
            // other settings (age (20), breastSize (3), kawaiiness (Tyan.Kawaiiness.Super))
            // are given in the TyanSearcher constructor
            var tyanSearcher = new TyanSearcher(tyanSearcherSettings, 20, 3, Tyan.Kawaiiness.Super);

            // array with names of tyans with searched parameters
            var foundTyans = tyanSearcher.Search();

            // output all found tyans
            Console.WriteLine("\n===== FOUND TYANS =====\n");

            // if found 0 tyans with specified parameters
            if (foundTyans == null)
            {
                Console.WriteLine("Found: 0");
                Console.ReadLine();
                return;
            }

            // if found 1+ tyan, output all
            foreach (var tyanName in foundTyans)
            {
                Console.WriteLine($"-> {tyanName}");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
