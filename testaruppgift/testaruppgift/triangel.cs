using System;
using System.Linq;
using System.Collections.Generic;

 
public struct Point { 
  public int x, y;
  
  public Point(int a, int b) {
    x = a;
    y = b;
  }
}

public class Triangle {
     double[] sides;
     private double _side1;
     private double _side2;
     private double _side3;
     public const string errorMessage = "Alla sidor måste vara ett positivt tal som är större än 0!";
     public double Side1 // Egenskapen Side som kollar så att _side inte är ett negativt tal eller = 0
     {
         get
         {
             return _side1;
         }

         set
         {
             if (value <= 0)
             {
                 throw new ArgumentException(errorMessage);
             }
             
             _side1 =value;
         }
     }
     public double Side2 // Egenskapen Side som kollar så att _side inte är ett negativt tal eller = 0
     {
         get
         {
             return _side2;
         }

         set
         {
             if (value <= 0)
             {
                 throw new ArgumentException(errorMessage);
             }
             _side2 = value;
         }
     }
     public double Side3 // Egenskapen Side som kollar så att _side inte är ett negativt tal eller = 0
     {
         get
         {
             return _side3;
         }

         set
         {
             if (value <= 0)
             {
                 throw new ArgumentException(errorMessage);
             }
             _side3 = value;
         }
     }

  public Triangle(double a, double b, double c) {

      if (a < (b + c) && a > (b - c))
      {
         Side1 = a;
         Side2 = b;
         Side3 = c;
         sides = new double[] { Side1, Side2, Side3 };
      }
      else { throw new ArgumentException("De angivna värdena du angett kan inte bli en triangel!"); }
  } 

  public Triangle(double[] s) {
    sides = new double[s.Length];
    /*for(int i=0;i<s.Length;i++) sides[i]=s[i];*/
    Side1 = sides[0];
    Side2 = sides[1];
    Side3 = sides[2];

  } 

  public Triangle(Point a, Point b, Point c) {
    
    sides = new double[3];
    sides[0] = Math.Sqrt(Math.Pow((double)(b.x - a.x), 2.0) + Math.Pow((double)(b.y - a.y), 2.0)); 
    sides[1] = Math.Sqrt(Math.Pow((double)(b.x - c.x), 2.0) + Math.Pow((double)(b.y - c.y), 2.0)); 
    sides[2] = Math.Sqrt(Math.Pow((double)(c.x - a.x), 2.0) + Math.Pow((double)(c.y - a.y), 2.0));
  }

  public Triangle(Point[] s) {
    sides = new double[s.Length];
    sides[0] = Math.Sqrt(Math.Pow((double)(s[1].x - s[0].x), 2.0) + Math.Pow((double)(s[1].y - s[0].y), 2.0));
    sides[1] = Math.Sqrt(Math.Pow((double)(s[1].x - s[2].x), 2.0) + Math.Pow((double)(s[1].y - s[2].y), 2.0));
    sides[2] = Math.Sqrt(Math.Pow((double)(s[2].x - s[0].x), 2.0) + Math.Pow((double)(s[2].y - s[0].y), 2.0));
  }

  private int uniqueSides() {
    return sides.Distinct<double>().Count();
  }

  public bool isScalene() {  //oliksidig
    if(uniqueSides()==3)
    return true;
    return false;
    
  }

  public bool isEquilateral() { //liksidig
      if (uniqueSides() == 1) 
          return true;
          return false;
  }

  public bool isIsosceles() { //likbent
    if(uniqueSides()==2)
    return true;
    return false;
  }
}


