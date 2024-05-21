using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_test
{
    public interface IFigure
    {
        double CalculateArea();
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            //значения сторон заносятся по возрастанию
            //простейшая сортировка
            if (sideA > sideB) (sideA, sideB) = (sideB, sideA);
            if (sideB > sideC) (sideB, sideC) = (sideC, sideB);
            if (sideA > sideB) (sideA, sideB) = (sideB, sideA);

            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        //метод для проверки треугольника на прямой угол
        static bool IsRightTriangle(double a, double b, double c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        public double CalculateArea()
        {
            //если треугольник прямоугольный то высчитываем по формуле 
            if (IsRightTriangle(SideA, SideB, SideC))
            {
                return SideA * SideB / 2;
            }
            else
            {
                //если нет, то используем формулу Герона
                var s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }

        }
    }
}
