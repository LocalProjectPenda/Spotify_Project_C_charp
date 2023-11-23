using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Album
    { public int id {  get; set; }
        public string _title {  get; set; }
      public string _releaseDate {  get; set; }
      public int _numTrack {  get; set; }
      public bool _liveVersion {  get; set; }
        public Song _song;
        public Artist _artist;
        public List<Song> songs;
     

        public Album() { }
        public Album(int id, string title, string releaseDate, int numTrack, bool liveVersion)
        {
            this.id = id;   
            _title = title;
            _releaseDate = releaseDate;
            _numTrack = numTrack;
            _liveVersion = liveVersion;
            songs = new List<Song>();
            _artist.AddAlbum(this);
           
        }

        //Song
        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void ListSong()
        {


            foreach (var i in songs)
            {

                Console.WriteLine(this._title + " : " + i._title + " " + i._genre + " " + i._releaseDate + " " + i._duration);

            }

        }

       
       
    }
}
