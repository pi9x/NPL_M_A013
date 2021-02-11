using System;
using AMSLibrary.Managements;

namespace AMSConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            AirportsManagement a = AirportsManagement.GetInstance(@"d:\airports.json");
            AirportsManagement b = AirportsManagement.GetInstance(@"d:\airports2.json");

            //Console.WriteLine(a == b);

            a.CreateAirport("Tan Son Nhat", 30.4, 20, 40);

            b.CreateAirport("Lien Khuong", 23, 10, 20);

            //am.AddAirport("Noi Bai", 23, 10, 20);

            //am.AddFixedwing("AP00001", "FW00001");

            //am.AddFixedwing("AP00001", "FW00002");

            //am.AddFixedwing("AP00002", "FW00003");

            //am.AddHelicopter("AP00001", "RW00005");

            //am.AddHelicopter("AP00001", "RW00006");

            //am.DeleteFixedwing("AP00003", "FW00003");

            //try
            //{
            //    am.AddFixedwing("AP00003", "FW00006");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            Console.WriteLine("Done!");
        }
    }
}
