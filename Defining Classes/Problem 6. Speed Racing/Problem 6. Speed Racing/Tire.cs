using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6._Speed_Racing
{
    public class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public double Pressure
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }
    }
}
