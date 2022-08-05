using Figures;
using NUnit.Framework;
using System;

namespace TestSquare
{
    [TestFixture]
    public class Tests
    {
        Circle circle;
        Triangle triangle;
        [SetUp]
        public void Setup()
        {
            circle = new Circle();
            triangle = new Triangle();
            int a = 0;
        }

        [Test]
        [TestCase(2, 2 * Math.PI)]
        [TestCase(5, 5 * Math.PI)]
        [TestCase(10.53, 10.53 * Math.PI)]
        [TestCase(0.00001, 0.00001 * Math.PI)]
        public void CheckRightAnswerCircle(double r, double answer)
        {
            circle.Radius = r;
            Assert.AreEqual(answer, circle.CalcSquare());
            Assert.Pass();
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        public void CheckArgumentExceptionCircle(double r)
        {
            Assert.Throws<ArgumentException>(() => circle.Radius = r);
        }


        [Test]
        [TestCase(3,4,5,6)]
        [TestCase(6, 8, 10, 24)]
        [TestCase(7.5, 10, 12.5,37.5)]
        public void CheckRightAnswerTriangle(double a, double b, double c, double answer)
        {
            triangle.A = a; triangle.B = b; triangle.C = c;
            Assert.AreEqual(answer, triangle.CalcSquare());
            Assert.Pass();
        }

        [Test]
        [TestCase(-5,3,0)]
        [TestCase(0,0,0)]
        [TestCase(10,10,0)]
        [TestCase(10, 10, -1)]
        public void CheckArgumentExceptionTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => {
                triangle.A = a;
                triangle.B = b;
                triangle.C = c;
                });
        }

        [Test]
        [TestCase(3,4,5)]
        [TestCase(3,5,4)]
        [TestCase(5,4,3)]
        public void CheckRightRectangular(double a, double b, double c)
        {
            triangle.A = a; triangle.B = b; triangle.C = c;
            Assert.IsTrue(triangle.isRectangular());
        }

        [Test]
        [TestCase(3, 10, 5)]
        [TestCase(7, 5, 4)]
        [TestCase(5, 4, 5)]
        public void CheckWrongRectangular(double a, double b, double c)
        {
            triangle.A = a; triangle.B = b; triangle.C = c;
            Assert.IsFalse(triangle.isRectangular());
        }
    }
}