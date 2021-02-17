using System;
using System.IO;
using JsonHomeWork;
using Newtonsoft.Json;

namespace SerializationHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader("JsonFile.json");
            string text = stream.ReadToEnd();
            string[] masChar = new string[] { "\r", "\n" };
            foreach (string charEl in masChar)
            {
                text = text.Replace(charEl, "");
            }

            var result = JsonConvert.DeserializeObject<WetherReport>(text);

            Console.ReadLine();
        }
    }


}
