using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LibraryCalculate
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            IFigure figure = new Circle(5);
            Assert.That(Math.PI * Math.Pow(5, 2), Is.EqualTo(figure.CalculateArea()));
        }

        [TestCase(5, 4, 3, ExpectedResult = 6)]//прямоугольный
        [TestCase(25, 40, 25, ExpectedResult = 300)]
        [TestCase(51, 52, 53, ExpectedResult = 1170)]
        [TestCase(13, 5, 12, ExpectedResult = 30)]
        [TestCase(8, 15, 17, ExpectedResult = 60)]
        [Test]
        public double TestTriangleArea(double side1, double side2, double side3)
        {
            IFigure figure = new Triangle(side1, side2, side3);
            return figure.CalculateArea();
        }
    }
}
