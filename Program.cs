using System;
using System.Linq;

namespace DeepSea
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = new DeepSeaContext();
      var allCreatures = db.Creatures;
      var input = "";
      //   while (input != "Q" || input != "U")
      //   {


      Console.Clear();
      Console.WriteLine("Welcome To DEEP SEA LIBRARY \n\nPress ENTER to Continue");
      Console.ReadKey();


      foreach (var data in allCreatures)
      {
        Console.WriteLine("\n");
        Console.WriteLine($"NAME : {data.Species} \nLOCATION: {data.LocationOfLastSeen} \n# OF TIMES SEEN: {data.CountOfTimesSeen}\n");
      }
      Console.WriteLine("Would you like to UPDATE, VIEW, DELETE or EXIT?\n");
      input = Console.ReadLine().ToUpper();


      if (input == "UPDATE")
      {

        Console.WriteLine("Which Creature Would You Like to Update?.\n");

        input = Console.ReadLine();
        var chosenCreature = db.Creatures.FirstOrDefault(c => c.Species.ToUpper() == input.ToUpper());
        var oneCreatureData = $"NAME : {chosenCreature.Species} \nLOCATION: {chosenCreature.LocationOfLastSeen} \n# OF TIMES SEEN: {chosenCreature.CountOfTimesSeen}\n";

        Console.WriteLine(oneCreatureData);
        Console.WriteLine("Would you like to update LOCATION or AMOUNTSEEN ?");
        input = Console.ReadLine().ToUpper();

        if (input != "AMOUNTSEEN")
        {
          Console.WriteLine("What is the new location?");
          input = Console.ReadLine();
          chosenCreature.LocationOfLastSeen = input;
          db.SaveChanges();
          Console.Clear();
          Console.Write("Data Updated.");
        }
        else
        {
          chosenCreature.CountOfTimesSeen++;
          db.SaveChanges();
          Console.Write("Data Updated.");
        }

      }
      else if (input == "VIEW")
      {
        Console.WriteLine("Which Location Would Like to Filter By?.\n");
        input = Console.ReadLine();

        var locationFilter = db.Creatures.Where(c => c.LocationOfLastSeen.ToUpper() == input.ToUpper());
        Console.WriteLine("\n");
        foreach (var data in locationFilter)
        {
          Console.WriteLine($"NAME : {data.Species} \nLOCATION: {data.LocationOfLastSeen} \n# OF TIMES SEEN: {data.CountOfTimesSeen}\n");
        }
      }
      else if (input == "DELETE")
      {
        Console.WriteLine("What location would you like to remove?.\n");
        input = Console.ReadLine();

        var locationDelete = db.Creatures.Where(c => c.LocationOfLastSeen.ToUpper() == input.ToUpper());
        db.Creatures.RemoveRange(locationDelete);
        db.SaveChanges();
        Console.Write("Data Updated.");


      }




      // if (input == "Q") break;
      //}

    }
  }
}

