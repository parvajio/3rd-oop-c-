using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(23,8);
            ComplexNumber c2 = new ComplexNumber(22 ,7);

            Console.WriteLine("c1 == c2: " + (c1 == c2));
        }
    }
    class ComplexNumber
    {
        public int X;
        public int Y;

        public ComplexNumber(int X, int Y){
            this.X = X;
            this.Y = Y;
        }

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            bool isXEqual = c1.X == c2.X;
            bool isYEqual = c1.Y == c2.Y;
            return isXEqual && isYEqual;
        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }
    }
}