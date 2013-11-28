using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void CheckisIsosceles()
        {
            //Testar ifall trianglen är likbent
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckisIsosceles2()
        {
            //Testar ifall trianglen är likbent
            Triangle tri = new Triangle(6, 5, 7);
            Assert.IsFalse(tri.isIsosceles()); // ger ett godkänt resultat om funktionen returnerar true
        }

        [TestMethod]
        public void CheckisScalene()
        {
            //Testar ifall trianglen är oliksidig
            Triangle tri = new Triangle(5.0, 6.5, 7.0);
            Assert.IsTrue(tri.isScalene()); // ger ett godkänt resultat om funktionen returnerar true
        }

        [TestMethod]
        public void CheckisScalene2()
        {
            //Testar ifall trianglen är oliksidig
            Triangle tri = new Triangle(5.0, 5.0, 5.0);
            Assert.IsFalse(tri.isScalene()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckisEquilateral()
        {
            //Testar ifall trianglen är liksidig
            Triangle tri = new Triangle(5.0, 5.0, 5.0);
            Assert.IsTrue(tri.isEquilateral()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckisEquilateral2()
        {
            //Testar ifall trianglen är liksidig
            Triangle tri = new Triangle(5, 6, 7);
            Assert.IsFalse(tri.isEquilateral()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckConstructor1_isIsosceles()
        {            
            //Testar ifall trianglen är likbent
           Point point1 = new Point(0, 0);
           Point point2 = new Point(4, 8);
           Point point3 = new Point(6, 2);
           Triangle tri = new Triangle(point1, point2, point3);
           Assert.IsTrue(tri.isIsosceles()); // ger ett godkänt resultat om triangeln med points är liksidig 
        }
        [TestMethod]
        public void CheckConstructor1_isScalene()
        {

            //Testar ifall trianglen är oliksidig
            Point point7 = new Point(-4, 1);
            Point point8 = new Point(1, 0);
            Point point9 = new Point(-2, -5);
            Triangle tri3 = new Triangle(point7, point8, point9);
            Assert.IsTrue(tri3.isScalene());
        }

        [TestMethod]
        public void CheckConstructor2_isIsosceles()
        {
            //Testar ifall triangeln är likbent
                 Point[] pointArray2 = new Point[3];
                 pointArray2[0] = new Point(0, 0);
                 pointArray2[1] = new Point(4, 8);
                 pointArray2[2] = new Point(6, 2);
                 Triangle tri2 = new Triangle(pointArray2);
                 Assert.IsTrue(tri2.isIsosceles());  
        }

        [TestMethod]
        public void CheckConstructor2_isScalene()
        {
            //Testar ifall trianglen är oliksidig
            Point[] pointArray3 = new Point[3];
            pointArray3[0] = new Point(-4, 1);
            pointArray3[1] = new Point(1, 0);
            pointArray3[2] = new Point(-2, -5);
            Triangle tri3 = new Triangle(pointArray3);
            Assert.IsTrue(tri3.isScalene());
        }
    }
}