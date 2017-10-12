using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance
{
    abstract class Vehicle
    {
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        private float gearRatio;
        private float engineSize;
        protected double distanceTraveled;

        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }


        public Vehicle()
        {
        }


        public Vehicle (int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;
        }

        public virtual void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }

        public virtual string 


        //public abstract void StartEngine(int keycode); // this is just an example of a very seldom used tactic to force 
                                                         //child class developers to write their own method for StartEngine()

    }

}
