using System;

namespace DeepSea
{
  class SampleData
  {
    static void SampleMain(string[] args)
    {

      var db = new DeepSeaContext();

      db.Creatures.Add(new Creature

      {
        Species = "Radiation Eel",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Coral Jungle"

      });
      db.Creatures.Add(new Creature

      {
        Species = "Laser Shark",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Red Sea"

      });
      db.Creatures.Add(new Creature

      {
        Species = "Bubblegum Fish",
        CountOfTimesSeen = 10,
        LocationOfLastSeen = "Tonga Trench"

      });
      db.Creatures.Add(new Creature

      {
        Species = "Glow Octupus",
        CountOfTimesSeen = 2,
        LocationOfLastSeen = "Red Sea"

      });
      db.Creatures.Add(new Creature

      {
        Species = "Unicorn Seahorse",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Coral Jungle"

      });
      db.Creatures.Add(new Creature

      {
        Species = "Rainbow Shrimp",
        CountOfTimesSeen = 100,
        LocationOfLastSeen = "The Red Sea"

      });

      db.SaveChanges();




    }
  }
}
