using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CsharpSandbox_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = ReadFrom("samplequotes.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.Read();
        }
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }                     
            }
        }
    }
}
