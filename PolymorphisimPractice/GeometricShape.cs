using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphisimPractice
{
    // Base GeometricShape class of definition

    public class GeometricShape
    {
        // Property of definiton
        public double Width { get; set; }
        public double Height { get; set; }

        public virtual double AreaCalculate()
        {

            return Width * Height;
        }



        // Inheriting the square class from the geometrics class

        public class Square : GeometricShape
        {
            // Constructor for Square 
            public Square(double side)
            {
                Width = side;
                Height = side;

            }
        }

        // Inheriting the rectange class from the geometrics class

        public class Rectangle : GeometricShape
        {
            // Constructor for  Rectangle
            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;

            }
        }

        //Inheriting the righttriange class from the geometrics class

        public class RightTriangle : GeometricShape
        {
            // Constructor for Right Triangle 

            public RightTriangle(double width, double height)
            {
                Width = width;
                Height = height;

            }

            public override double AreaCalculate()
            {
                return (Width * Height) / 2;
            }
        }

    }
}
