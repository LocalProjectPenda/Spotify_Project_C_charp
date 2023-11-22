using SpotyFake.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Media : IMedia
    {
        public void Play(Song song)
        {
            if (song != null)
            {
                Console.WriteLine($" listen : {song._title}");
            }
        }
        public void Stop(Song song) 
        {
            Console.WriteLine($" Stop : {song._title}");

        }
        public void Pause(Song song) 
        {
            Console.WriteLine($" Pause : {song._title}");

        }
        public void Next(Song song)
        {
            Console.WriteLine($" Next : {song._title}");

        }
        public void Prevew(Song song) 
        {
            Console.WriteLine($" Prevew : {song._title}");

        }
    }
}
