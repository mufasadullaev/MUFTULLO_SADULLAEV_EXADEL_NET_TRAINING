using System;
using System;
using System.Linq;
using System.Threading.Tasks;
using Task5.Models;

namespace Task5
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            return await ReadAsync();
        }
        public async static Task<int> ReadAsync()
        {
            Menu();
            using (var schoolContext = new SchoolContext())
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("New subject name: ");
                    var newSubject = Console.ReadLine();
                    var mySubject = new Subject { Name = newSubject };
                    schoolContext.Subjects.Add(mySubject);
                    await schoolContext.SaveChangesAsync();
                }
                else if (userInput == 2)
                {
                    var getSubject = await GetSubject();
                    Console.Write("New subject name: ");
                    var newSubject = Console.ReadLine();
                    getSubject.Name = newSubject;
                    await schoolContext.SaveChangesAsync();
                    Console.WriteLine("Subject name updated to: {0}", getSubject.Name);
                }
                else if (userInput == 3)
                {
                    var getSubject = await GetSubject();
                    schoolContext.Subjects.Remove(getSubject);
                    await schoolContext.SaveChangesAsync();
                }
                else if (userInput == 4)
                {
                    var getSubject = await GetSubject();
                    Console.WriteLine(getSubject.Name);
                }
                else if (userInput == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Choose a correct option!");
                }
            }
            Console.WriteLine('\n');
            return await ReadAsync();
        }
        public static async Task<Subject> GetSubject()
        {
            using (var schoolContext = new SchoolContext())
            {
                Console.Write("Choose subject ID: ");
                int subjectId = Convert.ToInt32(Console.ReadLine());
                return await schoolContext.Subjects.FindAsync(subjectId);
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
