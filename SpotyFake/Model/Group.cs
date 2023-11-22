using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Group
    {
        public string _nameGroup;
        public string _descriptionGroup;

        public Album _album;
        public List<Song> songs;
        public List<Artist> _artists;
        public Group() { }
        public Group( string nameGroup, string description)
        {
            _nameGroup = nameGroup;
            _descriptionGroup = description;
            _artists = new List<Artist>();
        }
        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        public void AddAlbum(Album album)
        {
            _album = album;
        }

    }
}
