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
        public void CheckRightAnswer(double r, double answer)
        {
            circle.Radius = r;
            Assert.AreEqual(answer, circle.CalcSquare());
            Assert.Pass();
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(null)]
        public void CheckArgumentException(double r)
        {
            circle.Radius = r;
            Assert.Throws<ArgumentException>(() => circle.CalcSquare());
        }   
    }
}