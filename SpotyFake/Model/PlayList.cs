using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class PlayList
    {
        public string _namePlaylist {  get; set; }
        public List<Song> _songs;
        public User _user;
        public PlayList() { }

    }
}
