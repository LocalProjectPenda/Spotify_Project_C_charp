using System;
using System.Drawing;
using SpotyFake.Controller;
using SpotyFake.Model;


namespace SpotyFake.Model
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tM - MUSIC");
            Console.WriteLine("\tC - PROFILE");
            Console.WriteLine("\tA - ARTIST");
            Console.WriteLine("\tD - ALBUM");
            Console.WriteLine("\tP - PLAYLIST");
            Console.WriteLine("\tR - RADIO");
            Console.WriteLine("\tZ - SEARCH");
            Console.WriteLine("\tL - PLAYER");
            char choice = Convert.ToChar(Console.ReadLine());

            ScreenController screenController = new ScreenController();
            screenController.SelectOption(choice);





            // ARTIST

            List<Song> songMadonna = new List<Song>();
            Song ExtremeOccident = new Song(1, "ExtremeOccident", "", "", 20);
            Song Loca = new Song(2, "loca", "", "", 20);
            Song Dark = new Song(3, "Dark", "", "", 20);

            songMadonna.Add(ExtremeOccident);
            songMadonna.Add(Loca);
            songMadonna.Add(Dark);


            List<Album> albumMadonna = new List<Album>();

            Album MadameX = new Album() { id = 1, _title = "MadameX", _releaseDate = "2019", _liveVersion = false, _numTrack = 3, songs = songMadonna };
            Album MadameY = new Album() { id = 2, _title = "MadameY", _releaseDate = "2012", _liveVersion = false, _numTrack = 3, songs = songMadonna };
            Album MadameZ = new Album() { id = 3, _title = "MadameZ", _releaseDate = "2003", _liveVersion = false, _numTrack = 3, songs = songMadonna };

            albumMadonna.Add(MadameX);
            albumMadonna.Add(MadameY);
            albumMadonna.Add(MadameZ);


            List<Artist> items = new List<Artist>();
           Artist Madonna = new Artist() { _idArtist = 1, _artName = "Madonna", albums = albumMadonna};
            Artist EdSheeran = new Artist() { _idArtist = 2, _artName = "Ed sheeran" };
            Artist Rihanna = new Artist() { _idArtist = 3, _artName = "Rihanna" };
            Artist ImagineDragon = new Artist() { _idArtist = 4, _artName = "Imagine Dragon" };
            Artist OneRepublic = new Artist() { _idArtist = 5, _artName = "One Republic" };
            Artist Gims = new Artist() { _idArtist = 6, _artName = "Gims" };
            Artist Stromae = new Artist() { _idArtist = 7, _artName = "Stromae" };
            Artist JohnLegende = new Artist() { _idArtist = 8, _artName = "John Legende" };
            Artist EllieGoulding = new Artist() { _idArtist = 9, _artName = "Ellie Goulding" };
            Artist RichieSpice = new Artist() { _idArtist = 10, _artName = "Richie Spice" };

            items.Add(Madonna);
            items.Add(EdSheeran);
            items.Add(Rihanna);
            items.Add(ImagineDragon);
            items.Add(OneRepublic);
            items.Add(Gims);
            items.Add(Stromae);
            items.Add(JohnLegende);
            items.Add(EllieGoulding);
            items.Add(RichieSpice);

           PlayList playlist = new PlayList("Bibliotheque") ;

            // Madonna

           

            Console.WriteLine(" Artist \n\n ");

            static void ListArtists(List<Artist> items, PlayList playlist)
            {
                
                foreach (var artist in items)
                {
                    Console.WriteLine(artist._idArtist + "   " + artist._artName);

                }
            
           ;
            

            Console.WriteLine("\n\n Select  ARTIST \n\n");
           
            int code = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("\n\n LIST ALBUM \n\n");
                var res = items.Where(i => i._idArtist == code).First<Artist>();
            List<Album> albums = res.albums;

                if (albums != null)
                {
                    foreach (var album in albums)
                    {
                        Console.WriteLine( "   " + album.id + "   " + album._title);

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
                                Console.WriteLine( "   " + song.Id + "   " + song._title);

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

            ListArtists(items, playlist);


           
            //switch (artist)
            //{
            //    case artist._idArtist:
            //        // Code à exécuter si variable correspond à option1
            //        break;
            //    case option2:
            //        // Code à exécuter si variable correspond à option2
            //        break;
            //    // Ajouter d'autres cases au besoin

            //    default:
            //        // Code à exécuter si aucune des options précédentes n'est satisfaite
            //        break;
            //}
        }
    }
}