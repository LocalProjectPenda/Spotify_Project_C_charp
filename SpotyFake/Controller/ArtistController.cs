using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class ArtistController
    {
        List<Artist> artists;
        PlayList playlists;
       
        public void ListArtists(List<Artist> items, PlayList playlist)
        {
            Console.WriteLine(" Artist \n\n ");
            foreach (var artist in items)
            {
                Console.WriteLine(artist._idArtist + "   " + artist._artName);

            }

 ;


            Console.WriteLine("\n\n Select  ARTIST \n\n");

            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n LIST ALBUM \n\n");
            var res = items.Where(i => i._idArtist == code).First<Artist>();
            List<Album> albums = res.albums;

            if (albums != null)
            {
                foreach (var album in albums)
                {
                    Console.WriteLine("   " + album.id + "   " + album._title);

                }

                Console.WriteLine("Select ALBUM");
                string choix = Console.ReadLine();
                Console.WriteLine("\n\n LIST SONG \n\n");
                int num;
                if (int.TryParse(choix, out num))
                {
                    var alb = albums.Where(i => i.id == num).First<Album>();
                    List<Song> list = alb.songs;
                    if (list != null)
                    {
                        foreach (var song in list)
                        {
                            Console.WriteLine("   " + song.Id + "   " + song._title);

                        }


                        Console.WriteLine("\n\n SELECT SONG \n\n");
                        string note = Console.ReadLine();
                        int son;
                        if (int.TryParse(note, out son))
                        {



                            var audio = list.Where(i => i.Id == son).First<Song>();
                            if (audio != null)
                            {

                                Media media = new Media();
                                media.Play(audio);


                                playlist._songs.Add(audio);

                            }
                        }
                        else
                        {
                            Console.WriteLine("La valeur entrée n'est pas un entier valide.");
                        }


                    }
                }
                else
                {
                    Console.WriteLine("La valeur entrée n'est pas un entier valide.");
                }

            }



        }


    }
}
