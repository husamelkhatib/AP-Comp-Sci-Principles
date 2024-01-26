using System;

class LP41 {
    public static void Main(String[] args) {
      Console.WriteLine("How many copies? ");
      int copies = int.Parse(Console.ReadLine());
        double cost = 0;
        double costPerCopy = 0;
        if (copies <= 0) {
            Console.WriteLine("How many copies do you actually want");
            copies = int.Parse(Console.ReadLine());
        }  else if ((copies > 0) && (copies < 100)) {
            costPerCopy = 0.3;
        } else if ((copies > 99) && (copies < 500)) {
            costPerCopy = 0.28;
        } else if ((copies > 499) && (copies < 750)){
            costPerCopy = 0.27;
        } else if ((copies > 749) && (copies < 1001)) {
            costPerCopy = 0.26;
        }  else {
            costPerCopy = 0.25;
        }
        cost = copies * costPerCopy;
        cost = Math.Round(cost * Math.Pow(10, 2)) / Math.Pow(10, 2);
        Console.WriteLine("Your total is: $" + cost);
    }
}