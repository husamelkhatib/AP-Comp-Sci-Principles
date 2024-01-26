using System;

  class MSOE2009Q4 {
    public static void Main(string[] args) {
      Console.WriteLine("Enter a lower bound: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter an upper bound: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter the amount of rectangles for the sum: ");
      int numOfRec = Convert.ToInt32(Console.ReadLine());

      double result = area(num1, num2, numOfRec);
      Console.WriteLine("The area under the curve is: " + result);
    }

    static double mult(double x) {
    return Math.Exp(-x * x / 2) / Math.Sqrt(2 * Math.PI);
    }

static double area(double num1, double num2, int numOfRec) {
double h = (num2 - num1) / numOfRec;
double sum = 0.0;

for (int i = 0; i < numOfRec; i++) {
sum += (num1 + i + h);
}
  return h * sum;
}
  }