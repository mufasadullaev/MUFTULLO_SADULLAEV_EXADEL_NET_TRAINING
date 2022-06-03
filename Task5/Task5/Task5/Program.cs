using System;
using System.Linq;
using Task5.Models;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                using (var schoolContext = new SchoolContext())
                {
                    Console.WriteLine("New subject name: ");
                    var newSubject = Console.ReadLine();
                    var mySubject = new Subject { Name = newSubject};
                    schoolContext.Subjects.Add(mySubject);
                    schoolContext.SaveChanges();
                }
            }
            else if (userInput == 2)
            {
                using (var schoolContext = new SchoolContext())
                {
                    Console.Write("Choose subject ID: ");
                    int subjectId = Convert.ToInt32(Console.ReadLine());
                    var getSubject = schoolContext.Subjects.Find(subjectId);
                    Console.Write("New subject name: ");
                    var newSubject = Console.ReadLine();
                    getSubject.Name = newSubject;
                    schoolContext.SaveChanges();
                }
            }
            else if (userInput == 3)
            {
                using (var schoolContext = new SchoolContext())
                {
                    Console.Write("Choose subject ID: \n\n");
                    int subjectId = Convert.ToInt32(Console.ReadLine());
                    var getSubject = schoolContext.Subjects.Find(subjectId);
                    schoolContext.Subjects.Remove(getSubject);
                    schoolContext.SaveChanges();
                }
            }
            else if (userInput == 4)
            {
                using (var schoolContext = new SchoolContext())
                {
                    Console.Write("Choose subject ID: ");
                    int subjectId = Convert.ToInt32(Console.ReadLine());
                    var getSubject = schoolContext.Subjects.Find(subjectId);
                    Console.WriteLine(getSubject.Name);
                    Console.ReadLine();
                }
            }
            else if (userInput == 5)
            {
                Environment.Exit(0);
            }
        }
        public static void Menu()
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Read");
            Console.WriteLine("5. Exit");
        }
    }
}
