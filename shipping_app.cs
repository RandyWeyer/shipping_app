using System;

class Program
{
  static double total = 0;
  static double shippingCalulation(int packageWeight, int distanceToTravel)
  {
    double priceModifier = .85;
    total = (packageWeight / 10) + (distanceToTravel / 5) * priceModifier;
    return total;
  }
  static void Main()
  {
    Console.WriteLine("What is the package weight?");
    string packageWeightString = Console.ReadLine();
    int packageWeight = int.Parse(packageWeightString);
    Console.WriteLine("What is the distance to travel?");
    string distanceToTravelString = Console.ReadLine();
    int distanceToTravel = int.Parse(distanceToTravelString);

    shippingCalulation(packageWeight, distanceToTravel);
    Console.WriteLine(total);
  }
}
