using System;

namespace HW_1_19_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //19-01-2021 
            //First Task
            double a = 16.80;
            double b = 12.40;
            double minGeometry = Math.Sqrt(a * b);
            Console.WriteLine($"MinGeometry = {minGeometry}");

            //Second Task
            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            double AC = Math.Abs(C - A);
            double BC = Math.Abs(C - B);
            Console.WriteLine($"Result = {AC + BC}");

            //Third Task
            double x1 = -6.20,
                   y1 = 5.20,
                   x2 = 2.10,
                   y2 = 9.80;
            double s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Distance = {s}");

            //Fourth Task
            int number = 41;
            int firstNumber = number / 10;
            int secondNumber = number % 10;
            int changed = secondNumber * 10 + firstNumber;
            Console.WriteLine($"Changed = {changed}");

            //Fifth Task
            int N = 10985;
            int Result = N / 60;
            Console.WriteLine($"Result = {Result}");

            //Sixth Task
            int K = 202;
            int dayIs = K % 7;
            Console.WriteLine($"dayIs = {dayIs}");
        }
    }
}
