//Encryption Basic
using System;

class Crypt
{
  static void Main()
  {
    Console.WriteLine("Enter a phrase");
    string yourPhrase = Console.ReadLine();

    string Encrypted = yourPhrase.Replace("e", "blahblahblah");
    Console.WriteLine(Encrypted);
    // Console.Write(Encrypted);
  }
}

//ShippingCost Basic
using System;

class ShippingCost
{
    static void Main()
    {
      Console.WriteLine("Enter weight");
      string yourWeight = Console.ReadLine();
      Console.WriteLine("Enter distance");
      string yourDistance = Console.ReadLine();
      Console.WriteLine("Enter price");
      string yourPrice = Console.ReadLine();

      int Weight = int.Parse(yourWeight);
      int Distance = int.Parse(yourDistance);
      int Price = int.Parse(yourPrice);

      Console.WriteLine("Your total price is:");
      Console.WriteLine(Weight + Distance + Price);
    }
}


//What did you eat Basic
using System;

class ShippingCost
{
    static void Main()
  {
    AskWhatYouAteFor("breakfast");
    AskWhatYouAteFor("lunch");
    AskWhatYouAteFor("dinner");
  }
  static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("you had " + yourMeal + " for " + meal + ".");
}

}
