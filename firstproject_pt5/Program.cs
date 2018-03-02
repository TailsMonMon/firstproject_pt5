using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject_pt5 {
    class Program {
        static void Main(string[] args) {
            Rectangle rect1;
            rect1.length=10;
            rect1.width=5;
            Console.WriteLine("Area of rect1 = {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(3, 3);

            rect2=rect1;
            rect1.length=63;    // To prove it's a reference, not a value.

            Console.WriteLine("rect2.length = {0}", rect2.length);

            Console.ReadLine();
        }

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
