namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int N = 3;
            //for (int i = 0; i < N; i++)
            //{

                ipAdresse ipServer1 = ipAdresse.GetInstance();
                ipServer1.IpServer();

            ipAdresse ipServer2 = ipAdresse.GetInstance();
            ipServer2.IpServer();

            //ipAdresse ipServer3 = ipAdresse.GetInstance();
            //ipServer3.IpServer();

            //ipAdresse ipServer4 = ipAdresse.GetInstance();
            //ipServer4.IpServer();



        }

    }



    } 