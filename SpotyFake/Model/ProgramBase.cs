using System;
using System.Drawing;
using Microsoft.VisualBasic.FileIO;
using SpotyFake.Controller;
using SpotyFake.Model;
using SpotyFake.FileSystem;
using SpotyFake.Time;
using System.Collections.Generic;


namespace SpotyFake.Model
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {



            #region Generic FileWriter  

            //string path = @"D:\Test\personne.csv";

            //List<Person> Persons = new List<Person>();
            //Persons.Add(new() { Name = "Bruno", Age = 40 });
            //Persons.Add(new() { Name = "Marco", Age = 30 });
            //Persons.Add(new() { Name = "Diego", Age = 20 });
            //Persons.Add(new() { Name = "Anna", Age = 10 });
            //Persons.Add(new() { Name = "Maria", Age = 24 });
            //Persons.Add(new() { Name = "Laura", Age = 50 });

            //DataStore<Person>.WriteonFile(path, Persons);

            #endregion

            #region Generic FileReader 
            string path = @"D:\Test\songs1.csv";//levare i .... sull file csv


            List<string> lines = File.ReadAllLines(path).ToList();



            List<Music> data = DataStore<Music>.CreateObject(lines);

            foreach (var p in data)
            {
               // Console.WriteLine(p.Id + " " + p.Rating + " " + p.Title + " " + p.Album + " " + p.Artist + " " + p.Genre + " " + p.Playlist + " " + p.PlaylistId);

            }
            #endregion



            // ARTIST

            List<Song> everySong = new List<Song>();
            Song ExtremeOccident = new Song(1, "ExtremeOccident", "pop", "", 20);
            Song Loca = new Song(2, "loca", "rock", "", 20);
            Song Dark = new Song(3, "Dark", "pop", "", 20);
            Song Reggaeton = new Song(4, "Baila", "latino", "", 20);
            Song cyber = new Song(5, "Cyber World", "reaggae", "", 20);
            Song One = new Song(3, "One fire", "hip hop", "", 20);

            everySong.Add(ExtremeOccident);
            everySong.Add(Loca);
            everySong.Add(Dark);


            List<Album> everyAlbum = new List<Album>();

            Album MadameX = new Album() { id = 1, _title = "MadameX", _releaseDate = "2019", _liveVersion = false, _numTrack = 3, songs = everySong };
            Album MadameY = new Album() { id = 2, _title = "MadameY", _releaseDate = "2012", _liveVersion = false, _numTrack = 3, songs = everySong };
            Album MadameZ = new Album() { id = 3, _title = "MadameZ", _releaseDate = "2003", _liveVersion = false, _numTrack = 3, songs = everySong };

            everyAlbum.Add(MadameX);
            everyAlbum.Add(MadameY);
            everyAlbum.Add(MadameZ);


            List<Artist> items = new List<Artist>();
           Artist Madonna = new Artist() { _idArtist = 1, _artName = "Madonna", albums = everyAlbum};
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
            
            PlayList playlist = new PlayList(1, "Bibliotheque");
            playlist.AddSong(ExtremeOccident);
            playlist.AddSong(Loca);
            playlist.AddSong(Dark);

            List<PlayList> playlists = new List<PlayList>();
            playlists.Add(playlist);
          Subscription basic = new Subscription(NameSubs.Basic, 50, 100);
          Subscription premium = new Subscription(NameSubs.Premium, 100,1000);
          Subscription gold = new Subscription(NameSubs.Gold, 150,0);

            User user1 = new User() { _name = "penda", _surname= "cisse", _birthday = "40", _userName = "admin", _password = "password123", _subscription = basic , _playlist = playlists };
            User user2 = new User() { _name = "Anta", _surname = "Kebe", _birthday = "27", _userName = "", _password = "", _subscription = premium, _playlist = playlists };
            User user3 = new User() { _name= "aicha", _surname ="niang", _birthday = "35", _userName = "", _password="", _subscription= premium, _playlist= playlists };
            User user4 = new User() { _name = "papa", _surname = "niasse", _birthday = "18", _userName = "", _password = "", _subscription = premium, _playlist = playlists };
            User user5 = new User() { _name = "mari", _surname = "sy", _birthday = "19", _userName = "", _password = "", _subscription = premium, _playlist = playlists };
            User user6 = new User() { _name = "nafi", _surname = "diop", _birthday = "32", _userName = "", _password = "", _subscription = premium, _playlist = playlists };
            User user7 = new User() { _name = "mouha", _surname = "ba", _birthday = "60", _userName = "", _password = "", _subscription = premium, _playlist = playlists };
            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);

         

            Radio radio = new Radio(everySong, everyAlbum, items);
            // Madonna


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
            

            switch (char.ToUpper(choice))
            {
                case 'M':
                    Console.WriteLine(" Option MUSIC ");
                    
                    MusicController music = new MusicController();
                    music.GetAllSoong(data);
                    break;
                case 'C':
                    Console.WriteLine($" Option PROFILE");
                    break;
                case 'A':
                    Console.WriteLine(" Option ARTIST ");
                    ArtistController artistC = new ArtistController();
                    artistC.ListArtists(items, playlist);
                    break;
                case 'D':
                    Console.WriteLine($" Option ALBUM");
                    AlbumController album = new AlbumController();
                    album.ListAlbum(everyAlbum, playlist);
                    break;
                case 'P':
                    Console.WriteLine("Option PLAYLIST");
                    Console.WriteLine("USER NAME");
                    string userName = Console.ReadLine();
                    Console.WriteLine("PASSWORD");
                    string Password = Console.ReadLine();
                    Console.WriteLine("SELECT LANGUAGE");
                    Console.WriteLine("\t1 - ENGLISH");
                    Console.WriteLine("\t2 - FRENCH");
                    Console.WriteLine("\t3 - ITALIAN");
                    Console.WriteLine("\t4 - GERMAN");
                    int language = Convert.ToInt32(Console.ReadLine());
                    ConfigDate configDate = new ConfigDate();
                    configDate.AutomaticConvertion(language);
                    ProfileController profile = new ProfileController();
                   bool result = profile.CheckLogin(users, userName, Password);
                    if (result)
                    {
                        
                        PlaylistController playLists = new PlaylistController();
                        var user = users.Where(i => i._userName == userName && i._password == Password).First<User>();
                       // List<PlayList> list = user._playlist;

                        playLists.ListFavori(user, everyAlbum);
                    }
                    else {
                        Console.WriteLine(" LOGIN OR PASSWORD FAILED");
                   }
                    break;
                case 'R':
                    Console.WriteLine("Option RADIO");
                    RadioController radioCont = new RadioController();
                    radioCont.GetSoong(radio, playlist);
                    break;
                case 'Z':
                    Console.WriteLine("Option SEARCH");
                    Console.WriteLine("Choose favori search");
                    Console.WriteLine("\t1 - ALBUM");
                    Console.WriteLine("\t2 - ARTIST");
                    Console.WriteLine("\t3 - SONG");
                    int val = Convert.ToInt32(Console.ReadLine());

                   MusicController musicController = new MusicController();
                    musicController.Search(val, data);
                    break;
                case 'L':
                    Console.WriteLine("Option PLAYER");
                    break;
            }
           



            Console.WriteLine(" HOME \n\n ");




           
        }
    }
}