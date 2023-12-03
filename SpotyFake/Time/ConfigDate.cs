using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Time
{
    internal class ConfigDate
    {

        static void CalcDates()
        {

            Console.WriteLine(DateTime.Now);

            DateTime berlin = new DateTime(1989, 11, 09);
            int yearBerlinWallFall = berlin.Year;
            int monthBerlinWallFall = berlin.Month;
            int dayBerlinWallFall = berlin.Day;

            int BerlinWallAniversary = DateTime.Now.Year - yearBerlinWallFall;

            Console.WriteLine(BerlinWallAniversary);
        }
        static void TimeZonelist()
        {
            TimeZoneInfo timeZoneNY = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            Console.WriteLine($"" +
                $"Pacific Standard Time: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Pacific Standard Time")}" +
               $"\nCentral Standard Time: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Central Standard Time")}" +
               $"\nIndia Standard Time: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "India Standard Time")}" +
               $"\nEastern Standard Time: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Eastern Standard Time")}" +
               $"\nNY Time: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneNY)}" +
               $"\nTokyo Standard Time: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")}"


               );

        }
        static void GetDateFromInput()
        {
            //Console.WriteLine("Inserire una data:");
            //string input = Console.ReadLine();

            //DateTime result;

            //if (DateTime.TryParse(input, out result))
            //{
            //    Console.WriteLine($" TryParse da stringa a Data Riuscito: {result} ");
            //}
            //else
            //{
            //    Console.WriteLine(".....");
            //}
            #region DATE FORMATS
            //DateTime.Now.ToString("MM/dd/yyyy") --> 05 / 01 / 2015
            //DateTime.Now.ToString"dddd, dd MM(MM yyyy") --> Friday, 29 May 2015
            //DateTime.Now.ToString("dddd, dd MMMM yyyy") --> Friday, 29 May 2015 05:50
            //DateTime.Now.ToString("dddd, dd MMMM yyyy") --> Friday, 29 May 2015 05:50 AM
            //DateTime.Now.ToString("dddd, dd MMMM yyyy") --> Friday, 29 May 2015 5:50
            //DateTime.Now.ToString("dddd, dd MMMM yyyy") --> Friday, 29 May 2015 5:50 AM
            //DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")    --> Friday, 29 May 2015 05:50:06
            //DateTime.Now.ToString("MM/dd/yyyy HH:mm") -->   05/ 29/2015 05:50
            //DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") -->    05/29/ 2015 05:50 AM
            //DateTime.Now.ToString("MM/dd/yyyy H:mm") -->    05/29/2015 5:50
            //DateTime.Now.ToString("MM/dd/yyyy h:mm tt") --> 05/29/2015 5:50 AM
            //DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")  -->   05/29/2015 05:50:06
            //DateTime.Now.ToString("MMMM dd") -->    May 29
            //DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK") -->  2015 - 05 - 16T05: 50:06.7199222 - 04:00
            //DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’") -->  Fri, 16 May 2015 05:50:06 GMT
            //DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss") -->  2015 - 05 - 16T05: 50:06
            //DateTime.Now.ToString("HH:mm") -->  05:50
            //DateTime.Now.ToString("hh:mm tt") -->   05:50 AM
            //DateTime.Now.ToString("H:mm") -->   5:50
            //DateTime.Now.ToString("h:mm tt") -->    5:50 AM
            //DateTime.Now.ToString("HH:mm:ss") -->   05:50:06
            //DateTime.Now.ToString("yyyy MMMM")
            #endregion

            #region Force Specific Format and Culture  Expressed in string to DateTime Object

            string input2 = "mercoledì, 29 marzo 2023 02:30"; // > input utente
            string Dateformat = "dddd, dd MMMM yyyy HH:mm"; // Formato
            CultureInfo culture = new CultureInfo("en-US"); // > culture input
            DateTime output;


            if (DateTime.TryParseExact(input2, Dateformat, culture, DateTimeStyles.RoundtripKind, out output))
            {
                Console.WriteLine($"{output.ToString("dddd, dd MMMM yyyy HH:mm")} ");
            }
            else
            {
                Console.WriteLine("TryParse FAILED");
            }
            #endregion


        }
        static void CreateTimeSpan()
        {
            TimeSpan timeSpan = new TimeSpan(0, 23, 59, 59);

            //DateTime myDate1 = DateTime.Now.Add(timeSpan);
            //Console.WriteLine(myDate1);
            DateTime myDate1 = DateTime.Now;
            Console.WriteLine(myDate1);

            DateTime myDate2 = DateTime.Now.AddMinutes(5);
            Console.WriteLine(myDate2);

            DateTime myDate3 = myDate2.Subtract(timeSpan);
            Console.WriteLine(myDate3);
        }
        public void AutomaticConvertion(int language)
        {
            if(language == 1) 
            {
                string dateInUSA = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("en-US"));
                string dateIso = DateTime.UtcNow.ToString("o");
                Console.WriteLine(dateInUSA);
                Console.WriteLine(dateIso);

            }
            if (language == 2) 
            {
                string dateInFR = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("fr-FR"));
                string dateIso = DateTime.UtcNow.ToString("o");

                Console.WriteLine(dateInFR);
                Console.WriteLine(dateIso);


            }
            if (language == 3) 
            {
                string dateInIT = DateTime.UtcNow.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("it"));
                string dateIso = DateTime.UtcNow.ToString("o");

                Console.WriteLine(dateInIT);
                Console.WriteLine(dateIso);

            }
            if (language == 4)
            {
                string dateInDE = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("de"));
                Console.WriteLine(dateInDE);

            }

        }
        static void CurrentCultureInfo()
        {
            // Ottenere la cultura corrente del thread
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("Current Culture: " + currentCulture.Name);

            // Ottenere la cultura corrente dell'interfaccia utente
            CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
            Console.WriteLine("Current UI Culture: " + currentUICulture.Name);

            // Oppure, utilizzando direttamente la classe CultureInfo
            CultureInfo directCurrentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Direct Current Culture: " + directCurrentCulture.Name);
        }
    }
}
