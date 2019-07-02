using System;
using System.Collections.Generic;

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

                var group2 = new Group()
                {
                    Name = "Metallica",
                };

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song(){Name = "Unforgiven", GroupId = group2.Id},
                    new Song(){Name = "Mutter", GroupId = group.Id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Song Group: {song.Group?.Name}");
                }
                
            }
        }
    }
}
