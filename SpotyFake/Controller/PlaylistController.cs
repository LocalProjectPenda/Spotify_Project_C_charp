using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class PlaylistController
    {
        public void ListFavori(PlayList playlist, List<Album>albums)
        {
            
         
            Console.WriteLine("\n\n LIST SONG \n\n");
           
               
                List<Song> list = playlist._songs;
                if (list != null)
                {
                    foreach (var s in list)
                    {
                        Console.WriteLine("   " + s.Id + "   " + s._title);

                    }


                    Console.WriteLine("\n\n SELECT SONG ");
                    Console.WriteLine("-N-  FOR NEW SONG  \n\n");

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
                    else if (note == "n"||note == "N")
                {

                    AlbumController album = new AlbumController();
                    album.ListAlbum(albums, playlist);


                }
                else
                    {
                        Console.WriteLine("La valeur entrée n'est pas un entier valide.");
                    }


                }
            




        }
        //public void AddPlaysong(Song song) 
        //{ 

        //}
    }
}
