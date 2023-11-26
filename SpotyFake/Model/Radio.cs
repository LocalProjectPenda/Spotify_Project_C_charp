using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Radio
    {


        public List<Song> _songs;
        public List<Album> _albums;

        public List<Artist> _artists;


        public Radio(List<Song> songs, List<Album> albums, List<Artist> artists)
        {

            _songs = songs;
            _albums = albums;
            _artists = artists;
        }

        //public void SearchGender(string gender)
        //{
        //    var son = 
        //}
    }
}
