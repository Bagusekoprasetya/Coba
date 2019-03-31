using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void taxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty)
                Console.WriteLine("OnDuty : Yes");
            else
                Console.WriteLine("OnDuty : No");

            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
            Console.WriteLine();
        }
    
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }

        public void DropOffPassenger ()
        {
            Console.WriteLine("{0} Selesai Menjemput penumpang", DriverName);
               }

    }

}
