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
            string edit1="=============================================\n";

            string edit2 = $"        {"",-50}    ";
            string edit3="Roaster for next race\n=============================================\n";
            string formattedNumber=AverageTime().ToString("F2");
            return edit1+edit2+edit3+$"Name:{Name}  Age: {Age}      Height: {Height} hands   Average run: {formattedNumber} seconds";
        }
    }
}
