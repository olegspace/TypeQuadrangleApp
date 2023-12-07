using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TypeQuadrangleApp;

namespace TestQuadrangleTypeApp
{
    [TestClass]
    public class QuadrangleTest
    {
        [TestMethod]
        public void Square()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(0, 2);
            a.dots[2] = new Point(2, 2);
            a.dots[3] = new Point(2, 0);


            Assert.AreEqual(a.Type(), "квадрат");
        }

        [TestMethod]
        public void Quadrangle()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(0, 4);
            a.dots[2] = new Point(6, 4);
            a.dots[3] = new Point(6, 0);

            Assert.AreEqual(a.Type(), "прямоугольник");
        }

        [TestMethod]
        public void Parallelogram()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(1, 4);
            a.dots[2] = new Point(5, 4);
            a.dots[3] = new Point(4, 0);

            Assert.AreEqual(a.Type(), "параллелограмм");
        }

        [TestMethod]
        public void Rhombus()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(-2, 3);
            a.dots[2] = new Point(0, 6);
            a.dots[3] = new Point(2, 3);

            Assert.AreEqual(a.Type(), "ромб");
        }
        [TestMethod]
        public void SimpleTrapezoid()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(1, 3);
            a.dots[2] = new Point(4, 3);
            a.dots[3] = new Point(8, 0);

            Assert.AreEqual(a.Type(), "трапеция общего вида");
        }

        [TestMethod]
        public void IsosceleTtrapezium()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(2, 3);
            a.dots[2] = new Point(5, 3);
            a.dots[3] = new Point(7, 0);

            Assert.AreEqual(a.Type(), "равнобедренная трапеция");
        }

        [TestMethod]
        public void Arbitrary()
        {
            Quadrangle a;
            a = new Quadrangle();
            a.dots[0] = new Point(0, 0);
            a.dots[1] = new Point(1, 7);
            a.dots[2] = new Point(5, 4);
            a.dots[3] = new Point(-1, 2);

            Assert.AreEqual(a.Type(), "произвольный");
        }
    }
}
