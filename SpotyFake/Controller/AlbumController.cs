using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class AlbumController
    {
        public void ListAlbum(List<Album> albums, PlayList playlist)
        {
            
            Console.WriteLine("\n\n LIST ALBUM \n\n");
           
            
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
