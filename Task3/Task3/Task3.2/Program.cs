using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader city = new StreamReader("../../city.json"))
            using (StreamReader people = new StreamReader("../../inhabitant.json"))
            {
                string cJson = city.ReadToEnd();
                string pJson = people.ReadToEnd();
                dynamic cityArray = JsonConvert.DeserializeObject(cJson);
                dynamic peopleArray = JsonConvert.DeserializeObject(pJson);
                foreach (var c in cityArray)
                {
                    if ( c["population"] > 50000)
                    {
                        foreach (var p in peopleArray)
                        {
                            if (p["city"] == c["city"])
                            {
                                if (p["age"] > 15 && p["age"] < 65)
                                {
                                    Console.WriteLine($"{p["name"]} {p["surname"]} is employable");
                                }
                                else
                                {
                                    Console.WriteLine($"{p["name"]} {p["surname"]} is not employable");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
