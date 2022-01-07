using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using BabyLib;

namespace ClassDemo2021Mack2
{
    internal class UdpWorker
    {
        public UdpWorker()
        {
        }

        public void Start()
        {

            UdpClient client = new UdpClient(7000);

            IPEndPoint remoteEP = null;

            while (true)
            {
                byte[] bytes = client.Receive(ref remoteEP);

                String str = Encoding.UTF8.GetString(bytes);

                Console.WriteLine(str);

                String[] strs = str.Split(',');

                int unitNo = Convert.ToInt32(strs[0]);
                int breath = Convert.ToInt32(strs[1]);
                int cry = Convert.ToInt32(strs[2]);


                Console.WriteLine("Baby græder " + BabyCool.AlarmCry(cry));


            }


        }
    }
}