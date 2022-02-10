using System;
using System.Collections.Generic;
// using Scrabble;

namespace Scrabble.Logic
{
    public class ScrabbleGame
    {
        public static double Score(string scrabbleWord)
        {
            string scrabbleWordToScore = scrabbleWord.ToLower();
            double totalScore = 0.0;

            for (int i = 0; i < scrabbleWordToScore.Length; i++)
            {
            char[] onePointers = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
            char[] twoPointers = {'d', 'g'};
            char[] threePointers = {'b', 'c', 'm', 'p'};
            char[] fourPointers = {'f', 'h', 'v', 'w', 'y'};
            char[] fivePointers = {'k'};
            char[] eightPointers = {'j', 'x'};
            char[] tenPointers = {'q', 'z'};
            if ((Array.Exists<char>( onePointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 1.11;
                }
            else if ((Array.Exists<char>( twoPointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 2.50;
                }
            else if ((Array.Exists<char>( threePointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 3.50;
                }
            else if ((Array.Exists<char>( fourPointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 4.50;
                }
            else if ((Array.Exists<char>( fivePointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 5.65;
                }
            else if ((Array.Exists<char>( eightPointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 8.01;
                }
            else if ((Array.Exists<char>( tenPointers, element => element == scrabbleWordToScore[i])))
                {
                    totalScore += 10.14;
                }
            }
            return Math.Round(totalScore, 4);
        }
    }
}