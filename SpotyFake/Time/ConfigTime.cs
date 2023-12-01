using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace SpotyFake.Time{

using System;
using System.Timers;



   class ConfigTime
{
    static Timer timer;
    static DateTime startTime;
    static TimeSpan totalTime;

    
        //Console.WriteLine("Appuyez sur Entrée pour démarrer le timer...");
        //Console.ReadLine();

        //StartTimer();

        //Console.WriteLine("Appuyez sur Entrée pour arrêter le timer...");
        //Console.ReadLine();

        //StopTimer();

        //Console.WriteLine("Temps écoulé : " + totalTime.ToString());

        //Console.WriteLine("Appuyez sur Entrée pour quitter le programme...");
        //Console.ReadLine();




       // Console.WriteLine(
       //"This example of TimeSpan.FromMinutes( double )\n" +
       //"generates the following output.\n");
       // //Console.WriteLine("{0,21}{1,18}",
       // //    "FromMinutes", "TimeSpan");
       // Console.WriteLine("{0,21}{1,18}",
       //     "-----------", "--------");

        //GenTimeSpanFromMinutes(0.00001);
        //GenTimeSpanFromMinutes(0.00002);
        //GenTimeSpanFromMinutes(0.12345);
        //GenTimeSpanFromMinutes(1234.56789);
        //GenTimeSpanFromMinutes(12345678.98765);
        //GenTimeSpanFromMinutes(0.01666);
        //GenTimeSpanFromMinutes(3);
        //GenTimeSpanFromMinutes(60);
        //GenTimeSpanFromMinutes(1440);
        //GenTimeSpanFromMinutes(30020.33667);
    


    public void StartTimer()
    {
        timer = new Timer();

        // Ajouter un délai et une action à exécuter à chaque intervalle
        timer.Interval = 1000; // 1 seconde
        timer.Elapsed += TimerElapsed;

        startTime = DateTime.Now; 
            
            //DateTime myDate = DateTime.Now.AddMinutes(1);
            //do
            //{
            //    Console.WriteLine(myDate.ToString() );
                // Démarrer le timer
                timer.Enabled = true;
            //} while (startTime <= myDate) ;
            //StopTimer();
    }

    public TimeSpan StopTimer()
    {
        // Arrêter le timer
        timer.Enabled = false;

        // Calculer le temps total écoulé
        totalTime = DateTime.Now - startTime;
            Console.WriteLine("Temps écoulé : " + totalTime.ToString());
            return totalTime;
        }

    public void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Action à exécuter à chaque intervalle
        Console.WriteLine("Temps écoulé : " + (DateTime.Now - startTime).ToString());

    }
        public TimeSpan GenTimeSpanFromMinutes(double minutes)
        {

            // Create a TimeSpan object and TimeSpan string from 
            // a number of minutes.
            TimeSpan interval = TimeSpan.FromMinutes(minutes);

            return interval;
            //string timeInterval = interval.ToString();

            //// Pad the end of the TimeSpan string with spaces if it 
            //// does not contain milliseconds.
            //int pIndex = timeInterval.IndexOf(':');
            //pIndex = timeInterval.IndexOf('.', pIndex);
            //if (pIndex < 0) timeInterval += "        ";

            //Console.WriteLine("{0,21}{1,26}", minutes, timeInterval);
        }
    }
}