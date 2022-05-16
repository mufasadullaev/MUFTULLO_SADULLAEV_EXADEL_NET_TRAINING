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
                string cityJson = city.ReadToEnd();
                string peopleJson = people.ReadToEnd();
                dynamic cityArray = JsonConvert.DeserializeObject(cityJson);
                dynamic peopleArray = JsonConvert.DeserializeObject(peopleJson);

            }
            Console.ReadLine();
        }

    }
}
