using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "paijo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.taxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            Console.WriteLine();
        }
    }
}
