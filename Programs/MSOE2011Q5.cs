using System;

class MSOE2011Q5 {
    private static double a6 = -0.09;
    private static double a5 = 1.6108;
    private static double a4 = -10.9167;
    private static double a3 = 4.37625;
    private static double a2 = -52.0433;
    private static double a1 = 31.1767;
    private static double a0 = -4;

    public static void Main(String[] args) {
        Console.WriteLine("Enter the guess for X:");
        double x = Convert.ToDouble(Console.ReadLine());

        int cnt = 0;
        bool cont = true;

        while (cont) {
            cnt++;
            x = x - f(x) / fPrime(x);
            Console.WriteLine("Number " + cnt + " x = " + x + " f(x) = " + f(x));

            cont = Math.Abs(f(x)) >= 0.001;
        }

        Console.WriteLine("The root found at x is: " + x);
    }

    static double f(double x) {
        return a6 * Math.Pow(x, 6) + a5 * Math.Pow(x, 5) + a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;
    }

    static double fPrime(double x) {
        return 6 * a6 * Math.Pow(x, 5) + a5 * Math.Pow(x, 4) + a4 * Math.Pow(x, 3) + a3 * Math.Pow(x, 2) + 2 * a2 * x + a1;
    }
}