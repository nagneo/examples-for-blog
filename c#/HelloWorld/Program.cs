using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Hello_World
{

    public class MyAttribute : Attribute
    {
        private string name;  
        public double version;  
  

        public MyAttribute(string name) {
            this.name = name;  
            version = 1.0;  
        }
    }


    [Obsolete("Refrigerator  is obsolete. Use Fridge instead.")]
    public class Refrigerator
    {
        public string Model { get; set; } = string.Empty;
    }

    [MyAttribute("The condenser should be checked when using the refrigerator.")]
    public class Fridge
    {
        public string Model { get; set; } = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fridge = new Refrigerator() { Model = "금성냉장고" };
            Console.WriteLine($"{fridge.Model}");

            var fridge2 = new Fridge() { Model = "LG냉장고" };
            Console.WriteLine($"{fridge2.Model}");
        }
    }
}

