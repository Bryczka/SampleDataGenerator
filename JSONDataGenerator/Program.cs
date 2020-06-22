using JSONDataGenerator.Model;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JSONDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            
            Generate100k(generator);
            Generate250k(generator);
            Generate500k(generator);
        }

        private static void Generate100k(Generator generator)
        {
            var a = new Docss()
            {
                docs = generator.Generate(31500, 3000, 65000, 400, 100)
            };
            var json = JsonSerializer.Serialize(a);
            System.IO.File.WriteAllText(@"..\..\..\100k.json", json);
        }

        private static void Generate250k(Generator generator)
        {
            var a = new Docss()
            {
                docs = generator.Generate(78750, 7500, 162500, 1000, 250)
            };
            var json = JsonSerializer.Serialize(a);
            System.IO.File.WriteAllText(@"..\..\..\250k.json", json);
        }

        private static void Generate500k(Generator generator)
        {
            var a = new Docss()
            {
                docs = generator.Generate(157500, 15000, 325000, 2000, 500)
            };
            var json = JsonSerializer.Serialize(a);
            System.IO.File.WriteAllText(@"..\..\..\500k.json", json);
        }
    }
}
