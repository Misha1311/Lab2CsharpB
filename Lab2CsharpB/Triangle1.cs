using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2CsharpB
{
    public struct Point2D
    {
        public int x;
        public int y;
    };

    class Triangle
    {
        int n = 3;
        Point2D[] points;
        public double[] lenght;
        double angle1 = 0;
        double angle2 = 0;
        double angle3 = 0;
        public double perimetr = 0;
        public double square = 0;
        public bool exist = true;
        Random rand = new Random();

        public double a;
        public double b;
        public double c;
        public Triangle()
        {

            points = new Point2D[3];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = rand.Next(0, 10);
                points[i].y = rand.Next(0, 10);
            }
        }

        public void IsExists()
        {
            for (int i = 0; i < n; i++)
            {
                if (lenght[i] + lenght[(i + 1) % n] <= lenght[(i + 2) % n])
                {
                    exist = false;
                    break;
                }

            }
        }

        public void Print()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x} Y  = {points[i].y}");
            }
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Lenght {i + 1} : {lenght[i]}");
            }
        }

        public void Lenght()
        {
            lenght = new double[n];

            for (int i = 0; i < n; i++)
            {
                lenght[i] = Math.Sqrt(Math.Pow(points[(i + 1) % n].x - points[i].x, 2) + Math.Pow(points[(i + 1) % n].y - points[i].y, 2));
            }

        }

        public void Angle()
        {
            a = lenght[0];
            b = lenght[1];
            c = lenght[2];

            angle1 = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
            angle2 = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            angle3 = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
            Console.WriteLine($"Angle 1 = {angle1}");
            Console.WriteLine($"Angle 2 = {angle2}");
            Console.WriteLine($"Angle 3 = {angle3}");
        }

        public void Perimetr()
        {
            perimetr = lenght[0] + lenght[1] + lenght[2];

            Console.WriteLine("Perimetr = " + perimetr);
        }

        public void Square()
        {
            square = 0.5 * a * b * Math.Sin(angle1);
            if (square < 0)
            {
                square *= -1;
            }
            Console.WriteLine($"Square = {square}");

        }
    };
}
