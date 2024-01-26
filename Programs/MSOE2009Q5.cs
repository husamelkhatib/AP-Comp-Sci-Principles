using System;

class MSOE2009Q5 {

    static bool IsPrime(int n) {
        if (n <= 1)
        return false;
        if (n <= 3)
        return true;

        if (n % 2 == 0 || n % 3 == 0)
        return false;

        int i = 5;
        while (i * i <= n) {
            if (n % i == 0 || n % (i + 2) == 0)
            return false;
            i += 6;
        }
        return true;
    }

    public static void Main(String[] args) {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0) {
            if (IsPrime(num))
            Console.WriteLine("prime");
            else
            Console.WriteLine("not prime");
        }      
    }
}