using System;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "Hello";
            var str2 = str1;
            str2 = "Bye";

            Console.WriteLine($"HashCode: {str1.GetHashCode()},\t String: {str1}");
            Console.WriteLine($"HashCode: {str2.GetHashCode()},\t String: {str2}");
            Console.WriteLine();

            var coffee1 = new Coffee() { Shot = 2, CoffeeBean = new CoffeeBean { Origin = "Brazil"} };
            var coffee2 = coffee1.Copy();
            coffee2.Shot = 1;
            coffee2.CoffeeBean.Origin = "Kenya";

            Console.WriteLine($"Coffee1 - HashCode: {coffee1.GetHashCode()},\tShot: {coffee1.Shot},\tOrigin: {coffee1.CoffeeBean.Origin}");
            Console.WriteLine($"Coffee2 - HashCode: {coffee2.GetHashCode()},\tShot: {coffee2.Shot},\tOrigin: {coffee2.CoffeeBean.Origin}");

            var coffee3 = coffee1.DeepCopy();
            coffee3.Shot = 3;
            coffee3.CoffeeBean.Origin = "Ethiopia";

            Console.WriteLine($"Coffee1 - HashCode: {coffee1.GetHashCode()},\tShot: {coffee1.Shot},\tOrigin: {coffee1.CoffeeBean.Origin}");
            Console.WriteLine($"Coffee3 - HashCode: {coffee3.GetHashCode()},\tShot: {coffee3.Shot},\tOrigin: {coffee3.CoffeeBean.Origin}");
            Console.ReadLine();
        }
    }
}
