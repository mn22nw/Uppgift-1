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
        public void CheckisScalene()
        {
            //Testar ifall trianglen är oliksidig
            Triangle tri = new Triangle(5.0, 6.5, 7.0);
            Assert.IsTrue(tri.isScalene()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckisEquilateral()
        {
            //Testar ifall trianglen är liksidig
            Triangle tri = new Triangle(5.0, 5.0, 5.0);
            Assert.IsTrue(tri.isEquilateral()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckConstructor1()
        {
            
            //Testar ifall trianglen är liksidig
           Point point1 = new Point(5, 0);
           Point point2 = new Point(5, 0);
           Point point3 = new Point(5, 0);
           Triangle tri = new Triangle(point1, point2, point3);
           Assert.IsTrue(tri.isEquilateral()); // ger ett godkänt resultat om triangeln med points är liksidig 

        //Testar ifall triangeln är likbent
           Point point4 = new Point(1, 0);
           Point point5 = new Point(0, 5);
           Point point6 = new Point(1, 0);
           Triangle tri2 = new Triangle(point4, point5, point6);
           Assert.IsTrue(tri2.isIsosceles()); // ger ej godkänt för det stämmmer inte nånstans 

           //Testar ifall trianglen är oliksidig
           Point point7 = new Point(5, 0);
           Point point8 = new Point(6, 5);
           Point point9 = new Point(7, 0);
           Triangle tri3 = new Triangle(point7, point8, point9);
           Assert.IsTrue(tri3.isScalene()); // ger ett godkänt resultat om triangeln med points är liksidig 
        }
        [TestMethod]
        public void CheckConstructor2()
        {
            //ifall triangeln är liksidig - Går ej hmm?!

            //Testar ifall triangeln är likbent
                 Point[] pointArray2 = new Point[3];
                 pointArray2[0] = new Point(0, 0);
                 pointArray2[1] = new Point(4, 8);
                 pointArray2[2] = new Point(6, 2);
                 Triangle tri2 = new Triangle(pointArray2);
                 Assert.IsTrue(tri2.isIsosceles());  

           //Testar ifall trianglen är oliksidig
            Point[] pointArray3 = new Point[3];
            pointArray3[0] = new Point(-4, 1);
            pointArray3[1] = new Point(1, 0);
            pointArray3[2] = new Point(-2, -5);
            Triangle tri3 = new Triangle(pointArray3);
            Assert.IsTrue(tri3.isScalene());  
        }

    // ** KOMMENTARER ** //
  /* Två av funktionerna (isEquilateral och isScalene) verkade från början vara fel uppbyggda då de i testerna 
     returnerade false*/
    }
}