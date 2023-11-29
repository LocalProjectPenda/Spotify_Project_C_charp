using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public sealed class ipAdresse
    {
       
        string[] ip = new string[4];
        int i;
        private static Random random;
        private static ipAdresse instance = null;
        private ipAdresse()
        {
            for (int i = 0; i < ip.Length; i++)
            {

                random = new Random();
                ip[i] = $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)} ";
               // Console.WriteLine($"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)} ");
                //Console.WriteLine(ip[i]);
            }


        }
        public static ipAdresse GetInstance()
        {
            if (instance == null)
            {
                instance = new ipAdresse();
            }
            return instance;
        }

        public void IpServer()
        {
            for (int i = 0; i < ip.Length; i++)
            {

                Console.WriteLine("ipServer" + ip[i]);

                //return ip[0];

            }

        }
    }
}
