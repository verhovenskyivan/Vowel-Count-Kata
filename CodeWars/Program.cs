using System;
using System.Linq;

public static class Kata
{
       public   static void Main()
    {
       static int GetVowelCount(string str) => str.Count(i => "aeiou".Contains(i));
    }
}