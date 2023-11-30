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

        public string _language { get; set; }
        
        public Setting Setting;
        public Subscription Subscription;
        

        
        public List<PlayList> _playlist;
        public User() { }

       public User(string name, string surname, string birthday, string userName, string password)
            :base(name, surname, birthday)
        {
            _userName = userName;
            _password = password;
           // _language = language; 
           _playlist = new List<PlayList>();

        }
        public void AddPlaylist(PlayList playList)
        {
            _playlist.Add(playList);
        }





    }
}
