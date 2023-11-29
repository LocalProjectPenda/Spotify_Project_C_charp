using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Song
    {
        public int Id { get; set; }
        public string _title { get; set; }
        public string _genre { get; set; }
        public string _releaseDate { get; set; }
        public double _duration { get; set; }
        public Artist _artist;
        public Album _album;
        public PlayList _playliste;
        public Music _radio;
        public List<Song> _song;
        

        

        public Song( int id, string title, string genre, string releaseDate, int duration)
        {
            Id = id;
            _title = title;
            _genre = genre;
            _releaseDate = releaseDate;
            _duration = duration;
            
        }

        public void ListSong()
        {


            foreach (var i in _song)
            {

                Console.WriteLine(i.Id + "  " + i._title + " " + i._genre + " " + i._releaseDate + " " + i._duration);

            }

        }

    }
}
