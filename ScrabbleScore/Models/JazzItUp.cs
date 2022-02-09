using System;
using System.Collections.Generic;
using Scrabble;

namespace Classy
{
    public class KeepItClassy
    {
        public static string whoIsClassy(string name) 
        {
          Console.WriteLine(name);
          string classyPerson = name + " you are classy!";
          return classyPerson;
        }
    }
}