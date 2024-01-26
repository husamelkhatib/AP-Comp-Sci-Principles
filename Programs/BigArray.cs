using System;
using System.Linq;

class BigArray {
  public static void Main(String[] args) {
    Random random = new Random();

    int[] array = new int[19];
  for (int i = 0; i < array.Length; i++) {
      array[i] = random.Next(20, 91);

      }


    // 1. Print the Array from the beginning to the end
    Console.Write("1. Print the Array from the beginning to the end: ");
    Console.WriteLine(string.Join(" ", array));

    // 2. Print the Array from the beginning to the end using a for-each loop
    Console.Write("2. Print the Array from the beginning to the end using a for-each loop: ");
    foreach (int number in array) {
      Console.Write(number + " ");  
      }
    Console.WriteLine();

    // 3. What number is in the middle of the Array?
    int middleNumber = array[array.Length / 2];
    Console.WriteLine("3. What number is in the middle of the Array: " + middleNumber);

    // 4. What is the average of the first, last and middle numbers?
    int firstNumber = array[0];
    int lastNumber = array[array.Length - 1];
    double average = (firstNumber + lastNumber + middleNumber) / 3.0;
    Console.WriteLine("4. What is the average of the first, last, and middle numbers: " + average);

    // 5. Find the smallest and the largest number in the Array
    int smallest = array[0];
    int largest = array[0];
    foreach (int number in array) {
      smallest = Math.Min(smallest, number);
      largest = Math.Max(largest, number);
    }
    Console.WriteLine("5. Find the smallest and the largest number in the Array: " + smallest + " " + largest);

    // 6. Switch the largest with smallest number. Print the list
    int indexSmallest = Array.IndexOf(array, smallest);
    int indexLargest = Array.IndexOf(array, largest);
    array[indexSmallest] = largest;
    array[indexLargest] = smallest;
    Console.WriteLine("6. Switch the larhest with smallest number.  Print the list: " + string.Join(" ", array));

    // 7. Create a new random from 1 to 10 and insert it in the middle slot. Print the numbers.
    Random rand = new Random();
    int randNum = rand.Next(1, 11);
    int midIndex = array.Length / 2;
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < newArray.Length; i++) {
      if (i < midIndex) {
        newArray[i] = array[i];
      } else if (i == midIndex) {
        newArray[i] = randNum;
      } else {
        newArray[i] = array[i - 1];
      }
    }
    Console.WriteLine("7. Create a new random from 1 to 10 and insert it in the middle slot. Print the numbers: " + string.Join(" ", newArray));

// 8. Add 10 to every number in the List. Print all.
    for (int i = 0; i < array.Length; i++) {
      array[i] += 10;
    }
    Console.WriteLine("8. Add 10 to every number in the List. Print all: " + string.Join(" ", array));

// 9. Replace the 3rd element in the array with 5 and print the number that was ousted (only use one method to complete this.)
    int ousted = array[2];
    array[2] = 5;
    Console.WriteLine("9. Replace the 3rd element in the array with 5 and print the number that was ousted (only use one method to complete this): " + string.Join(" ", array));

// 10. What numbers are in the 50s?
    Console.Write("10. What numbers are in the 50s: ");
    int count50s = 0;
    for (int i = 0; i < array.Length; i++) {
      if (array[i] >= 50 && array[i] < 60) {
        count50s++;
        Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Amount of numbers in the 50s: " + count50s);

// 11. What numbers are multiples of 4?
    int countMult4s = 0;
    Console.Write("11. What numbers are multiples of 4: ");
    for (int i = 0; i < array.Length; i++) {
      if (array[i] % 4 == 0) {
        countMult4s++;
        Console.Write(array[i] + " ");
      }
    }
    Console.WriteLine();
    Console.WriteLine("Amount of numbers that are multiples of 4: " + countMult4s);

// 12. Is there a 60 in the list?
    Console.WriteLine("12. Is there a 60 in the list: " + array.Contains(60));

// 13. Check to see if all of the elements from front to back are in the same order from back to front
    Console.WriteLine("13. Check to see if all of the elements from front to back are in the same order from back to front: " + array.SequenceEqual(array.Reverse()));

// 14. How many numbers are greater than the average?
    double avg = array.Average();
    Console.WriteLine("14. How many numbers are greater than the average: " + array.Count(i => i > avg));

// 15. How many of the numbers are even?
    int countEven = 0;
    Console.Write("15. How many of the numbers are even: ");
    for (int i = 0; i < array.Length; i++) {
      if (array[i] % 2 == 0) {
        countEven++;
        Console.Write(array[i] + " ");
      }
    }
    Console.WriteLine();
    Console.WriteLine("Amount of even numbers is: " + countEven);

// 16. Copy all of the elements of the array into a new array but in reverse order
    int[] reversed = array.Reverse().ToArray();
    Console.WriteLine("16. Copy all of the elements of the array into a new array but in reverse order: " + string.Join(" ", reversed));

// 17. Write a program to shift every element of an array circularly right. E.g.-INPUT : 1 2 3 4 5 OUTPUT : 5 1 2 3 4
    int[] shiftedRight = new int[array.Length];
    shiftedRight[0] = array[1];
    Array.Copy(array, 0, shiftedRight, 1, array.Length - 1);
    Console.WriteLine("17. Write a program to shift every element of an array circularly right: " + string.Join(" ", shiftedRight));

// 18. Find the sum of all of the digits of all of the elements
  int sum = array.Sum(x => x.ToString().Sum(i => i - '0'));
  Console.WriteLine("The array is: " + string.Join(" ", array));
  Console.WriteLine("18. Find the sum of all of the digits of all of the elements: " + sum);  
  }
}
