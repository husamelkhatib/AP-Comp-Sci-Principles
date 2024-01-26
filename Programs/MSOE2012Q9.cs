using System;
using System.Collections.Generic;
class MSOE2012Q9 {
  public static void Main(string[] args) {
    Dictionary<char, int> romanNumerals = new Dictionary<char, int>() {
      { 'I', 1 }, 
      { 'V', 5 },
      { 'X', 10 },
      { 'L', 50 },
      { 'C', 100 },
      { 'D', 500 }, 
      { 'M', 1000 }
    };

    Console.Write("The roman numeral is: ");
    string roman = Console.ReadLine().ToUpper();

    int prevNum = 0;
    int total = 0;

    for (int i = roman.Length-1; i >= 0; i--) {
      int currentNum = romanNumerals[roman[i]];
      if (currentNum < prevNum)
      total -= currentNum;
      else
      total += currentNum;

      prevNum = currentNum;
    }
    Console.WriteLine("Decimal Value: " + total);
  } 
}