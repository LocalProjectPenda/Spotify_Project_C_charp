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

        //public List<Song> songs;
        //public List<Music> radios;
        public List<PlayList> playlists;

       public User(string name, string surname, string birthday, string userName, string password, string language)
            :base(name, surname, birthday)
        {
            _userName = userName;
            _password = password;
            _language = language; 
           

        }
       public User()
        {

        }

        public bool Login(List<User> users, User user)
        {
            var us = users.Where(i => i._userName == user._userName && i._password == user._password).FirstOrDefault<User>();
            if (us._userName == "admin" && us._password == "password123")
            {

                return true; // Connexion réussie
            }
            else
            {
                return false; // Identifiants incorrects
            }

        }
        public void Logout() { }
        public void SigIn() { }

    }
}
