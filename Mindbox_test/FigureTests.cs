using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mindbox_test
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

        [TestCase(5, 4, 3, ExpectedResult = 6)]
        [Test]
        public void TestTriangleArea(double side1, double side2, double side3, double expectedArea)
        {
            IFigure figure = new Triangle(side1, side2, side3);
            Assert.That(expectedArea, Is.EqualTo(figure.CalculateArea()));
        }
    }
}
