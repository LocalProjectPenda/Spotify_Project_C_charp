using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class ProfileController
    {
        public void ConfigTime(User user)
        {
            User use = new User();

           
           // string langue = user._language;

       

        }
        public void Login(List<User> users,string userName, string Password ) 
        {

            CheckLogin(users, userName, Password);

            
            

        }
        public bool CheckLogin(List<User> users, string userName, string Password)
        {
           
            var us = users.Where(i => i._userName == userName && i._password == Password).FirstOrDefault<User>();
            if (us._userName == "admin" && us._password == "password123")
            {

                return true; // Connexion réussie
            }
            else
            {
                return false; // Identifiants incorrects
            }

        }

        public void FormatDate() 
        {

        }
        public void Logout() { }
        public void SigIn() { }


    }
}