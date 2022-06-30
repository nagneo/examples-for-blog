using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorInfo = GetColor();
            Console.WriteLine($"name: {colorInfo.Item1} " +
                                $"r:{colorInfo.Item2} " +
                                $"g:{colorInfo.Item3} " +
                                $"b:{colorInfo.Item4}");

            var colorInfo2 = GetNamedColor();
            Console.WriteLine($"name: {colorInfo2.Name} " +
                                $"r:{colorInfo2.R} " +
                                $"g:{colorInfo2.G} " +
                                $"b:{colorInfo2.B}");

            Console.ReadLine();
        }

        public static Tuple<string, int, int, int> GetColor()
        {
            return System.Tuple.Create("red", 255, 0, 0);
        }

        public static (string Name, int R, int G, int B) GetNamedColor()
        {
            return ("blue", 0, 255, 0);
        }
    }
}
