using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherOne1
{
    internal class Horse
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public double[] Times { get; set; }

        public Horse()
        {
            Times = new double[3];
        }

        public Horse(string name, int age, int height, double[] times)
        {
            Name = name;
            Age = age;
            this.Height = height;
            Times = times;
        }
        public double AverageTime()
        {
            return Times.Average();
        }
        public string HorseDetails()
        {
            return $"Name: {Name}\tAge: {Age}\tHeight: {Height}\tAverage run: {AverageTime()}";
        }
    }
}
