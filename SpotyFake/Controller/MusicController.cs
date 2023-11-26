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

        public void GetSoong(List<Music> music, PlayList playlist)
        {


            Console.WriteLine("\n\n LIST SONG \n\n");

           
            if (music != null)
            {
                foreach (var s in music)
                {
                    Console.WriteLine(s.Id + " " + s.Rating + " " + s.Title + " " + s.Album + " " + s.Artist + " " + s.Genre + " " + s.Playlist + " " + s.PlaylistId);

                }


                //Console.WriteLine("\n\n SELECT SONG ");
                //Console.WriteLine(" SELECT ARTIST  \n\n");

                //string artist = Console.ReadLine().ToLower();

                //if (artist !=null)
                //{



                //    var artists = music.Where(i => i.Artist == artist);
                //    foreach (var s in artist)
                //    {
                //        Console.WriteLine(s.Id + " " + s.Rating + " " + s.Title + " " + p.Album + " " + p.Artist + " " + p.Genre + " " + p.Playlist + " " + p.PlaylistId);

                //    }


                //}
                //else
                //{
                //    Console.WriteLine("La valeur entrée n'est pas un entier valide.");
                //}


            }





        }

    }
}
