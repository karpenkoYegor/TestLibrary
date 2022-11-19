using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class Circle : IFigure
    {
        private double _radius;
        public double Radius 
        { 
            get 
            {
                return _radius;
            }
            set
            {
                _radius = (value > 0) ? value : 0;
            }
        }
        public Circle(double radius)
        {
            Console.WriteLine("Фигура круг");
            Radius = radius;
        }
        public double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
