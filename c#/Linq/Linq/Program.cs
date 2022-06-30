using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffees = DataGenerator.Generate(10000);

            // Query Syntax
            var queryCoffees = from coffee in coffees where coffee.Flavor.Bitter < 6 orderby coffee.Flavor.Bitter select coffee;

            // Method Syntax
            var methdodCoffees = coffees.Where(c => c.Flavor.Bitter < 6).OrderBy(c => c.Flavor.Bitter);

            // MixedQuery 
            var mixedCount = (from coffee in coffees where coffee.Flavor.Bitter < 6 orderby coffee.Flavor.Bitter select coffee).Count

        }
    }
}
