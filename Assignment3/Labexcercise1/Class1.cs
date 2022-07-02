using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labexcercise1
{
     class Class1

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area and perimeter of shapes");
            Circle circle = new Circle();
            Console.WriteLine("The area and perimeter of a circle");
            Console.WriteLine("Enter the radius");
            circle.radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of the circle is: ");
            Console.WriteLine(circle.getArea());
            Console.WriteLine("The Perimeter of the circle is: ");
            Console.WriteLine(circle.getPerimeter());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Area and perimeter of the circle");
            Square square = new Square();
            Console.WriteLine("Enter the length");
            square.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width");
            square.width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of the square is: ");
            Console.WriteLine(square.getArea());
            Console.WriteLine("The Perimeter of the square is: ");
            Console.WriteLine(square.getPerimeter());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Area and perimeter of a triangle");
            Triangle triangle = new Triangle();
            Console.WriteLine("Enter the base of the triangle");
            triangle.base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle");
            triangle.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your length 1");
            triangle.length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your length 2");
            triangle.lenght2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of the triangle is: ");
            Console.WriteLine(triangle.getArea());
            Console.WriteLine("The Perimeter of the triangle is: ");
            Console.WriteLine(triangle.getPerimeter());



        }
    }
}
    

