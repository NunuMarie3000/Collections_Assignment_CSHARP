namespace CollectionExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXERCISE ONE
      // array of nums between 0-9
      int[] numArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      // array of names tim, martin, nikki, & sara
      string[] nameArr = { "Tim", "Martin", "Nikki", "Sara" };
      // array of true/false values, length of 10, starting with true
      bool[] boolArr = { true, false, true, false, true, false, true, false, true, false };

      
      // EXERCISE TWO
      //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!) 
      List<string> iceCreamFlavors = new List<string>();
      iceCreamFlavors.Add("Rocky Road");
      iceCreamFlavors.Add("Pralines & Cream");
      iceCreamFlavors.Add("S'mores");
      iceCreamFlavors.Add("Cookie Crisp");
      iceCreamFlavors.Add("Banana Nut");
      iceCreamFlavors.Add("Spongebob SpongePop");
      iceCreamFlavors.Add("Cocoa Crunch");
      //Output the length of this list after building it 
      Console.WriteLine($"Length of iceCreamFlavors is: {iceCreamFlavors.Count}");
      //Output the third flavor in the list,
      Console.WriteLine($"Third flavor in the list is: {iceCreamFlavors[2]}");
      // then remove this value
      iceCreamFlavors.RemoveAt(2);
      // Output the new length of the list (It should just be one fewer!)
      Console.WriteLine($"iceCreamFlavors after removing 3rd item: {iceCreamFlavors.Count}\n\n");


      // EXERCISE THREE
      //Create a dictionary that will store both string keys as well as string values
      Dictionary<string, string> myDictionary = new Dictionary<string, string>();
      // Add key/value pairs to this dictionary where: -each key is a name from your names array -each value is a randomly select a flavor from your flavors list. 
      Random random = new Random();
      myDictionary.Add(nameArr[0], iceCreamFlavors[random.Next(0, 7)]);
      myDictionary.Add(nameArr[1], iceCreamFlavors[random.Next(0, 7)]);
      myDictionary.Add(nameArr[2], iceCreamFlavors[random.Next(0, 7)]);
      myDictionary.Add(nameArr[3], iceCreamFlavors[random.Next(0, 7)]);
      //Loop through the dictionary and print out each user's name and their associated ice cream flavor
      foreach(var item in myDictionary)
        Console.WriteLine($"{item.Key} likes {item.Value} ice cream");
    }
  }
}