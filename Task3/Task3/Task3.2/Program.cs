using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string json1 = File.ReadAllText("../../inhabitant.json");
            string json2 = File.ReadAllText("../../city.json");
            var jsonPerson = JsonConvert.DeserializeObject<List<People>>(json1);
            var jsonCity = JsonConvert.DeserializeObject<List<People>>(json2);
            var employablePerson = from p in jsonPerson
                                   join c in jsonCity on p.city equals c.city
                                   where c.population > 50000
                                   select p;
            foreach (var i in employablePerson)
            {
                if (i.age > 15 && i.age < 65)
                {
                    Console.WriteLine($"{i.name} {i.surname} is employable");
                }
                else
                {
                    Console.WriteLine($"{i.name} {i.surname} is not employable");
                }
            }
            Console.ReadLine();
        }
    }
}
