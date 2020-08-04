using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace InternetOutageTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            toggleTracker();
        }

        public static void toggleTracker()
        {
            bool trackerOn = true;
            Ping ping = new Ping();



            while (trackerOn)
            {
                PingReply result = ping.Send("172.217.3.174");

                if (result.Status.Equals("Success"))
                {
                    Console.WriteLine($"Result: {result.Status}");
                    trackerOn = false;
                }
                else
                {
                    Console.WriteLine($"Result: {result.Status}");
                    trackerOn = false;
                }
                Thread.Sleep(10000);
            }
            

            //Console.WriteLine(result.Status);
        }
    }
}
