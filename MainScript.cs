using System;
using System.Net.Sockets;
using System.Threading;

namespace IPChecker
{
    public class MainScript
    {
        public static string _ip = "";
        public static int _port = 0;
        public static bool _serverIsRunning = false;

        public static void Main()
        {
            Console.WriteLine("Enter the IP: ");
            _ip = Console.ReadLine();
            Console.WriteLine("Enter the Port: ");
            _port = Console.Read();
            Console.Clear();
            while (!_serverIsRunning)
            {
                try
                {
                    using (TcpClient server = new TcpClient(_ip, _port))
                    {
                        Console.WriteLine("Server is running");
                        _serverIsRunning = true;
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Server is offline");
                    Thread.Sleep(100000);
                }
            }
            Console.ReadKey();
        }
    }
}