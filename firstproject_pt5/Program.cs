using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject_pt5 {
    class Program {
        static void Main(string[] args) {

            //      Structures and stuff around that
            Rectangle rect1;    // To create a rectangle from struct
            rect1.length=10;
            rect1.width=5; 
            Console.WriteLine("Area of rect1 is {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(5, 2);  // Another way to create a rectangle

            rect2=rect1;    // rect2 is the same as rect1
            rect1.length=63;    // To prove it's a value, not a reference. Values does not change. This basicly gets ignored. 

            Console.WriteLine("rect2.length = {0}", rect2.length);
            Console.WriteLine();
            Console.WriteLine();


            //      Classes     - Animal.cs     (menu > project > add class, choose name and save)
            Animal fox = new Animal() {
                name="Red",
                sound="Raaww"
            };
            Animal cat = new Animal() {
                name="Batman",
                sound="Mjauuu"
            };

            fox.MakeSound();    // To make the console print the "MakeSound" string (see Animal.cs)
            cat.MakeSound();
            Console.WriteLine("# of Animals = {0}", Animal.getNumberOfAnimals());
            Console.WriteLine();
            Console.WriteLine();
             

            //      Utility class   - ShapeMath.cs      (menu > project > add class, choose name and save)
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));
            Console.WriteLine("Area of Triangle : {0}", ShapeMath.GetArea("triangle", 5, 6));
            Console.WriteLine("Area of Circle : {0}", ShapeMath.GetArea("circle", 5, 6));
            Console.WriteLine();
            Console.WriteLine();


            //      Nullables types 
            int? aNumber = null;    // "?" makes is possible for a data to be null
            if (aNumber==null) {
                Console.WriteLine("aNumber is null");
            }
            if(!aNumber.HasValue) {     // "!" is an inverter
                Console.WriteLine("aNumber is still null");
            }


            Console.ReadLine();
        }

        //      Structures and stuff around that
        struct Rectangle {
            public double length;
            public double width; 

            public Rectangle(double l = 1, double w = 1) {
                length=l;
                width=w;
            }

            public double Area() {
                return length*width;
            }

        }
    }
}
