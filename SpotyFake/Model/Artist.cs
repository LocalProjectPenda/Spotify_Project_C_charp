using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Artist : Person
    {
        public int _idArtist { get; set; }
        public string _artName { get; set; }
        public string _description { get; set; }
        public Group _group;
        
       

        List<Song> songs;
        List<Album> albums;

        public Artist( int id, string artName, string description)
        {
            _idArtist = id;
            _artName = artName;
            _description = description;
            songs = new List<Song>();
            albums = new List<Album>();
            
        }

    

        // ALBUM

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }
        public void CreatAlbum(string title, string releaseDate, int numTrack, bool liveVersion)
        {
            Album album = new Album(title, releaseDate, numTrack, liveVersion);
            albums.Add(album);
        }

        public void RemoveAlbum(Album album)
        {
            List<Album> items = albums;
            var result = items.Where(i => i._title == album._title).FirstOrDefault<Album>();
            if (result != null)
            {
                result = null;
            }
        }


        //SONG
        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void CreateSong(int id, string title, string genre, string releaseDate, int duration)
        {
            Song song1 = new Song(id, title, genre, releaseDate, duration);
            songs .Add(song1);
        }
        // public void AddSong(int id, string title, string genre, string releaseDate, int duration)
        //{
        //     _song = new Song(id, title, genre, releaseDate, duration) ;
        // }
        public void RemoveSong(Song song)
        {
            List<Song> items = songs;
            var result = items.Where(i => i._title == song._title ).FirstOrDefault<Song>();
            if (result != null)
            {
                result = null;
            }
        }
        public void ListSong()
        {


            foreach (var i in songs)
            {

                Console.WriteLine(this._artName + " : " + i._title + " " + i._genre + " " + i._releaseDate + " " + i._duration);

            }

        }

      

    }
}
