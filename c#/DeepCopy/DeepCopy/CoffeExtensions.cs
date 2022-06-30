using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeepCopy
{
    public static class CoffeeExtensions
    {
        public static T DeepCopy<T>(this T source) where T : new()
        {
            if (!typeof(T).IsSerializable)
            {
                // fail
                return source;
            }

            try
            {
                object result = null;
                using (var ms = new MemoryStream())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(ms, source);
                    ms.Position = 0;
                    result = (T)formatter.Deserialize(ms);
                    ms.Close();
                }

                return (T)result;
            }
            catch (Exception)
            {
                // fail
                return new T();
            }
        }
    }
}
