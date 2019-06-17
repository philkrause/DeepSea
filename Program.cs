using System;
using System.Linq;

namespace DeepSea
{
  class Program
  {
    static void Main(string[] args)
    {

      while (true)
      {
        var db = new DeepSeaContext();
        var input = "";
        var allCreatures = db.Creatures;

        Console.Clear();
        Console.Write("Would you like to VIEW, UPDATE or DELETE? \n");
        input = Console.ReadLine().ToUpper();


        if (input == "VIEW")
        {

          foreach (var data in allCreatures)
          {
            Console.WriteLine("\n");
            Console.WriteLine("==========================");
            Console.WriteLine($"NAME : {data.Species} \nLOCATION: {data.LocationOfLastSeen} \n# OF TIMES SEEN: {data.CountOfTimesSeen}");
          }
          Console.WriteLine("Type Q to quit, M for the main menu, or U to update");
          input = Console.ReadLine().ToUpper();

          if (input == "U")
          {
            Console.Write("Which Creature Would You Like to Update?.\n");

            input = Console.ReadLine();
            var creatureNameInput = db.Creatures.FirstOrDefault(c => c.Species.ToUpper() == input.ToUpper());

            Console.WriteLine($"NAME : {creatureNameInput.Species} \nLOCATION: {creatureNameInput.LocationOfLastSeen} \n# OF TIMES SEEN: {creatureNameInput.CountOfTimesSeen}");

            // if (creatureNameInput != null)
            //     {

            //         creatureNameInput.CountOfTimesSeen++;
            //         db.SaveChanges();
            //         Console.Write("\n");
            //         Console.WriteLine($"{input} has been updated.\n");
            //         Console.WriteLine("Type Q to quit or M for the main menu?");
            //         input = Console.ReadLine().ToUpper();
            //     }

          }

        }

        if (input == "Q") break;
      }

    }
  }
}

