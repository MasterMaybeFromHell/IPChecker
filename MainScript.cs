using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace IPChecker
{
    public class MainScript
    {
        public static string _ip = "";
        public static bool _serverIsRunning = false;
        public static Ping _server = new Ping();

        public static void Main()
        {
            Console.WriteLine("Enter the IP and port of the server you want to check: ");
            _ip = Console.ReadLine();
            Console.Clear();
            while (!_serverIsRunning)
            {
                try
                {
                    _server.Send(_ip);
                    Console.WriteLine("Server is running");
                    _serverIsRunning = true;
                }
                catch
                {
                    Console.WriteLine("Server is offline");
                    Thread.Sleep(100000);
                }
            }
            Console.ReadKey();
        }
    }
}
