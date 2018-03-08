﻿using System;

namespace firstproject_pt5 {
    public static class ShapeMath {
        public static double GetArea(string shape="", 
            double length1=0, // x
            double length2=0 ) { // y

            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase)) {
                return length1*length2; // x*y
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase)) {
                return length1*(length2/2); // x/y
            }
            else if(String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase)) {
                return 3.14159*Math.Pow(length1, 2); // pi*x
            }
            else {
                return -1;
            }

        }
    }
}
