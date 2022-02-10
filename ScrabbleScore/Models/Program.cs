
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
            double total = ScrabbleGame.Score(scrabbleWord);
            Console.WriteLine("Total: {0:C}\n", total);
            Console.WriteLine("└(=^‥^=)┘");
        }
    }
}