using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class PlayList
    {
        public int _idPlayliste {  get; set; }
        public string _namePlaylist { get; set; }
        public List<Song> _songs;
        public List<PlayList> playLists;
        public User _user;

        //public PlayList() { }
        public PlayList(int id, string name)
        {
            _namePlaylist = name;
            _songs = new List<Song>();
           
        }
        public void AddSong(Song song)
        {
            _songs.Add(song);
        }
        public void ListSong(string name)
        {
            var play = playLists.Where(i => i._namePlaylist == name).FirstOrDefault<PlayList>();

            foreach (var i in play._songs)
            {

                Console.WriteLine(play._namePlaylist + " : " + i._title + " " + i._genre + " " + i._releaseDate + " " + i._duration);

            }

        }
    }
}
