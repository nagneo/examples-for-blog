using System;
using System.IO;
using System.Threading.Tasks;

namespace MvvmCounter
{
    public class FileCountSaver : ICountSaver
    {
        public void Save(int count)
        {
            Task.Run(() => {

                try
                {
                    var path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "result.txt");
                    using (var sw = File.AppendText(path))
                    {
                        sw.WriteLine($"{DateTime.Now}, {count}\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }


            });
        }
    }
}
