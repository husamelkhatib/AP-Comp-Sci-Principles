using System;

class MSOE2016Q4 {

  static int greatestCommonDiv(int num1, int num2) {
    while (num1 != 0) {
      int temp = num1;
      num1 = num2 % num1;
      num2 = temp;
    }
    return num2;
    }
    static int infinite(int n) {
      int result = 1;
      for (int i = 2; i < n; i++) {
        if (greatestCommonDiv(i, n) == 1) {
          result++;
        }
      }
      return result;
        }
    static void Main() {
    for (int n = 1; n <= 10; n++)
    Console.WriteLine("phi(" + n + ") = " + infinite(n));
    }
  }
