using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d); // abstracted vehicle class because no one is going to need to instantiate vehicle.

            //baseVehicle.Move();
            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);

            Automobile herbie = new Automobile(4, 13, 2, 4, 1500, "white", 88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile distance traveled: " +herbie.DistanceTraveled);

            Boat boaty = new Boat(2, 500, "red", 88, .9d);
            boaty.Move();
            boaty.Move();
            Console.WriteLine("Boat distance traveled: " + boaty.DistanceTraveled);

        }
    }
}
