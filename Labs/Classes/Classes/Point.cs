﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    public class Point   //in order to test this class it has to be public 
    {
        private int x;
        private int y; 
        private static int objectCount = 0;       //static means one per class 

        public Point()
        {
            Console.WriteLine("Default constructor called");
            this.x = -1;
            this.y = -1;
            objectCount++;       
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
            Console.WriteLine($"x:{x}, y:{y}");
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount() => objectCount;
    }
}
