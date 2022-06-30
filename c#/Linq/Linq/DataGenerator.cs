using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public static class DataGenerator
    {
        public static List<Coffee> Generate(int count)
        {
            if(count <= 0)
            {
                return null;
            }

            try
            {
                var coffees = new List<Coffee>();
                var names = new List<string>
                {
                    "Colombia Supremo",
                    "Ethiopia Yirgacheffe",
                    "Brazil Santos",
                    "Kenya AA",
                    "Guatemala Antigua",
                    "Indonesia Mandheling",
                    "Blue Mountain Blend",
                    "Ethiopia Sidamo",
                    "Costa Rica Tarrazu"

                };

                var rand = new Random();
                for (var i = 0; i < count; i++)
                {
                    var name = names[rand.Next(0, names.Count)];
                    var acidity = rand.Next(0, 9);
                    var bitter = rand.Next(0, 9);
                    var body = rand.Next(0, 9);
                    var item = new Coffee()
                    {
                        Name = name,
                        Flavor = new Flavor { Acidity = acidity, Bitter = bitter, Body = body }
                    };

                    coffees.Add(item);
                }

                return coffees;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return null;
            }
        }
    }
}
