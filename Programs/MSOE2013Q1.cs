using System;

class MSOE2016Q4 {
  public static void Main() {
    Console.WriteLine("Enter the resistance for 3");

    double resistance1 = Resistance();
    double resistance2 = Resistance();
    double resistance3 = Resistance();

    double parallelResistance = Calculate(resistance1, resistance2, resistance3);
    Console.WriteLine("Total resistance: " + parallelResistance + "ohms");
    }

  static double Resistance() {
    Console.WriteLine("resistance: ");
    double resistance;

    while (!double.TryParse(Console.ReadLine(), out resistance) || resistance <= 0) {
      Console.WriteLine("Invalid input");
      Console.WriteLine("resistance: ");
    }
    return resistance;
  }

  static double Calculate(double resistance1, double resistance2, double resistance3) {
    double opposite1 = 1 / resistance1;
    double opposite2 = 1 / resistance2;
    double opposite3 = 1 / resistance3;

    double totalOpposite = opposite1 + opposite2 + opposite3;

    double parallelResistance = 1 / totalOpposite;
    return parallelResistance;
  }
  }
