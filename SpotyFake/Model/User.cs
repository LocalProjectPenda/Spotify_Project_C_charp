using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class User:Person
    {
        public string _userName {  get; set; }
        public string _password { get; set; } = string.Empty;
        
        public Setting Setting;

        public List<Song> songs;
        public List<Music> radios;
        public List<PlayList> playlists;
    }
}
