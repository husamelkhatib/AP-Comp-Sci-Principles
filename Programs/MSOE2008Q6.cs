using System;

class MSOE2008Q6 {
public static void Main(string[] args) {
  string DNA = "CGATTACGCGACGAT";
  string target = "CGA";
  int cnt = CountCGA(DNA, target);

  Console.WriteLine("The target sequence " + target + " appears " + cnt + " times in the source.");

}
  static int CountCGA(string DNA, string target) {
    int cnt = 0;
    int index = 0;

    if (DNA != null && target != null && target.Length > 0) {
      while (index < DNA.Length) {
        int foundIndex = DNA.IndexOf(target, index);
        if (foundIndex >= 0) {
          cnt++;
          index = foundIndex + 1;
        } else {
          break;
        }
      }
    }
    return cnt;
  }
}