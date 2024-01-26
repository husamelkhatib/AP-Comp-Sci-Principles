using System;

class LP42 {
    public static void Main (String[] args) {
        Console.WriteLine("How much does it weigh?");
          int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("What is it's length in cm?");
           int length = int.Parse(Console.ReadLine());
        Console.WriteLine("What is it's width in cm?");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("What is it's height in cm?");
        int height = int.Parse(Console.ReadLine());
        if (weight > 27 && (length < 101) && (width < 101) && (height < 101)) {
            Console.WriteLine("Package is too heavy");
        } else if ((weight < 28) && ((length > 100) || (width > 100) || (height > 100))) {
            Console.WriteLine("Package too large");
        } else if ((weight > 27) && ((length > 100) || (width > 100) || (height > 100))) {
            Console.WriteLine("Package too heavy and too large");
        } else {
            Console.WriteLine("Package is fine");

        }
    }
}