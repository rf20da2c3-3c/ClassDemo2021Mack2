using System;

namespace ClassDemo2021Mack2
{
    class Program
    {
        static void Main(string[] args)
        {

            UdpWorker worker = new UdpWorker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
