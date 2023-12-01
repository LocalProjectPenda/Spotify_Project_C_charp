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
        public void ListFavori(User user, List<Album>albums)
        {
            Console.WriteLine("\n\n LIST PLAYLIST \n\n");
            
            List<PlayList>myPlaylists = user._playlist;

            if (myPlaylists != null)
            {
                foreach (var p in myPlaylists)
                {
                    
                    Console.WriteLine(p._idPlayliste+"   " +p._namePlaylist );
                   
                }
            }
            Console.WriteLine("\n\n SELECT PLAYLIST \n\n");
            int namePlay = Convert.ToInt32( Console.ReadLine());

            var myplaylist = myPlaylists.Where(i => i._idPlayliste == namePlay).First<PlayList>();

            Console.WriteLine("\n\n LIST SONG \n\n");
           
               
                List<Song> list = myplaylist._songs;
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

                       TimeSpan totalTime =  media.Play(audio);
                        Subscription subscription = user._subscription;


                        TimeSpan sub = subscription.GetSubscrib(subscription);
                        TimeSpan result = sub - totalTime;
                        
                        //user._subscription.timeSub =; --------------convert TimeSpan in double----------
                        Console.WriteLine("Temps restant : " + result.ToString());


                        myplaylist._songs.Add(audio);

                    }
                    }
                    else if (note == "n"||note == "N")
                {

                    AlbumController album = new AlbumController();
                    album.ListAlbum(albums, myplaylist);


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
