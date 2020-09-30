using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6GreenLibrary
{
    public class HybridClass
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int Miles { get; set; }

        public HybridClass() { }

        public HybridClass(string make, string model, int year, double price, int miles)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Miles = miles;
        }
    }
}
