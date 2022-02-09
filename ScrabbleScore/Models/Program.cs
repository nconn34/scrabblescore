using System;
using System.Collections.Generic;
using Scrabble.Logic;
using Classy;


namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter your name so we can class it up: ");
            string name = Console.ReadLine();
            Console.WriteLine(KeepItClassy.whoIsClassy(name));
            Console.Write("We are gonna score some scrabble tiles! Enter your word: ");
            string scrabbleWord = Console.ReadLine();
            string lowerCaseWord = scrabbleWord.ToLower();
            // Console.WriteLine(ScrabbleGame.Score(lowerCaseWord));
            double total = ScrabbleGame.Score(lowerCaseWord);
            Console.WriteLine("Total: {0:C}\n", total);
            Console.WriteLine("└(=^‥^=)┘");

        }
    }
}