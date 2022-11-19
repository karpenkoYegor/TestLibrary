using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class FigureBuilder
    {
        private double[] _sides;
        public FigureBuilder(params double[] sides)
        {
            _sides = sides;
        }

        public IFigure GetFigure()
        {
            IFigure? figure = _sides.Length switch
            {
                1 => new Circle(_sides[0]),
                3 => new Triangle(_sides[0], _sides[1], _sides[2]),
                _ => null
            };
            return figure;
        }
    }
}
