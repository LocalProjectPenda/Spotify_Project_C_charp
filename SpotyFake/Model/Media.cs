using SpotyFake.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpotyFake.Time;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Media : IMedia
    {
        ConfigTime configTime = new ConfigTime();
        TimeSpan totalTime;
        TimeSpan result;
        public void Play(Song song)
        {


            
            Console.WriteLine($" listen : {song._title}");
            Console.WriteLine("Appuyez sur Entrée pour démarrer le timer...");
            Console.ReadLine();

            //DateTime startTime = DateTime.Now;
            //DateTime myDate = DateTime.Now.AddMinutes(10);

            //if (myDate >= startTime )
            //{
                configTime.StartTimer();
            //}
            //else
            //{
            //    configTime.StopTimer();
            //}
            Console.WriteLine("Appuyez sur Entrée pour démarrer le timer...");
            Console.ReadLine();

            configTime.StopTimer();
        }
        public void Stop(Song song)
        {
            configTime.StopTimer();
            Console.WriteLine($" Stop : {song._title}");
            Console.WriteLine("Temps écoulé : " + totalTime.ToString());
            // TimeSpan result =  totalTime
            var us = song._playliste._user;
            var Subscription = us.Subscription;
            result = Subscription.timeSub - totalTime;
            Console.WriteLine("Temps restant : " + result.ToString());

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
