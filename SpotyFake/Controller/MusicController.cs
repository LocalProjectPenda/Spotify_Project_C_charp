using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class MusicController
    {
        public void Search(int val, List<Music> music)
        {

            if (val == 1)
            {

                GetRatingAlbum();


            }

            else if (val == 2)
            {
                GetRatingArtist();
            }
            else
            {
                GetAllSoong(music);

            }



            void GetRatingAlbum()
            {



                Console.WriteLine("\t-POP ");
                Console.WriteLine("\t-ROCK ");
                Console.WriteLine("\t-REAGGAE ");
                Console.WriteLine("\t-HIP HOP ");
                Console.WriteLine("\t-LATINO ");

                string gender = Console.ReadLine().ToLower();



                var list = music.Where(i => i.Genre == gender);
                List<Music> sortedlist = music.OrderByDescending(a => a.Rating).ToList();


                Console.WriteLine("TOP 5 Album :");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{sortedlist[i].Album} - Rating : {sortedlist[i].Rating}");
                }

            }

            void GetRatingArtist()
            {



                Console.WriteLine("\t-POP ");
                Console.WriteLine("\t-ROCK ");
                Console.WriteLine("\t-REAGGAE ");
                Console.WriteLine("\t-HIP HOP ");
                Console.WriteLine("\t-LATINO ");

                string gender = Console.ReadLine().ToLower();



                var list = music.Where(i => i.Genre == gender);
                List<Music> sortedlist = music.OrderByDescending(a => a.Rating).ToList();


                Console.WriteLine("TOP 5 Album :");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{sortedlist[i].Artist} - Rating : {sortedlist[i].Rating}");
                }

            }

        }
       public void GetAllSoong(List<Music> music)
        {


            Console.WriteLine("\n\n LIST SONG \n\n");


            if (music != null)
            {
                foreach (var s in music)
                {
                    Console.WriteLine(s.Id + " " + s.Rating + " " + s.Title + " " + s.Album + " " + s.Artist + " " + s.Genre + " " + s.Playlist + " " + s.PlaylistId);

                }

               
                
            }


        }
    }
       
}
    
