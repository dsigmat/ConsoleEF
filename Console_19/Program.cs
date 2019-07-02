using System;

namespace Console_19
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ApplicationContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };
                context.Groups.Add(group);
                context.SaveChanges();

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}.");
            }
        }
    }
}
