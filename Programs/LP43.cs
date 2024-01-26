using System; 

class LP43 {
    public static void Main (String[] args) {
        Console.WriteLine("How many eggs? ");
        int eggs = int.Parse(Console.ReadLine());
        double cost = 0;
        double costPerEgg = 0;
        if (eggs <= 0) {
            Console.WriteLine("How many eggs do you actually want");
            eggs = int.Parse(Console.ReadLine());
        }  else if ((eggs > 0) && (eggs < 48)) {
            costPerEgg = 0.5;
        } else if ((eggs > 47) && (eggs < 72)) {
            costPerEgg = 0.45;
        } else if ((eggs > 71) && (eggs < 132)){
            costPerEgg = 0.4;
        }  else {
            costPerEgg = 0.35;
        }

        cost = eggs * costPerEgg;
        cost = cost / 12;
        cost = Math.Round(cost * Math.Pow(10, 2)) / Math.Pow(10, 2);
        Console.WriteLine("Your total is: $" + cost);
    }
}