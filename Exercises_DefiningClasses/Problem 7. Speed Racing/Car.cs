using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Problem_7.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmout;
        private double fuelConsumption;
        private int distaceTravelled;


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmout
        {
            get
            {
                return this.fuelAmout;
            }
            set
            {
                this.fuelAmout = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public int DistanceTravelled
        {
            get
            {
                return this.distaceTravelled;
            }
            private set
            {
                this.distaceTravelled = value;
            }
        }

        public void Drive(int distance)
        {
            var neededFuel = this.fuelConsumption * distance;

            if (neededFuel > this.fuelAmout)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            else
            {
                this.DistanceTravelled += distance;
                this.FuelAmout -= neededFuel;
            }
        }
    }
}