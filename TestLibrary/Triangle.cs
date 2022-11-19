using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class Triangle : IFigure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private bool _isTriangle = true;
        public double FirstSide
        {
            get { return _firstSide; }
            set { _firstSide = (value > 0) ? value : 0; }
        }
        public double SecondSide
        {
            get { return _secondSide; }
            set { _secondSide = (value > 0) ? value : 0; }
        }
        public double ThirdSide
        {
            get { return _thirdSide; }
            set { _thirdSide = (value > 0) ? value : 0; }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            Console.WriteLine("Фигура тругольник");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            _isTriangle = FirstSide + SecondSide <= ThirdSide ||
                          ThirdSide + SecondSide <= FirstSide ||
                          FirstSide + ThirdSide <= SecondSide;
            if(_isTriangle)
                Console.WriteLine("Такого треугольника не существует");
        }

        public bool IsRightTriangle()
        {
            return FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide ||
                   ThirdSide * ThirdSide + SecondSide * SecondSide == FirstSide * FirstSide ||
                   FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide;
        }

        public double Square()
        {
            if (IsRightTriangle())
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (!_isTriangle)
            {
                var halfPerimetr = Perimetr() / 2;
                return Math.Sqrt(halfPerimetr * (halfPerimetr - FirstSide) * (halfPerimetr - SecondSide) * (halfPerimetr - ThirdSide));
            }
            Console.WriteLine("Такого треугольника не существует");
            return 0;
        }

        public double Perimetr()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
    }
}
