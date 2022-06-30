using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopy
{
    [Serializable]
    public class Coffee
    {
        public int Shot { get; set; }

        public CoffeeBean CoffeeBean { get; set; }

        public Coffee Copy()
        {
            return (Coffee)this.MemberwiseClone();
        }
    }

    [Serializable]
    public class CoffeeBean
    {
        public string Origin { get; set; }
    }
}
