using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2, 4);
            ComplexNumber c2 = new ComplexNumber(5, 6);

            ComplexNumber c3 = c1 + c2;
            ComplexNumber c4 = c1 + 5;
            ComplexNumber c5 = c2 - c1;
            ComplexNumber c6 = c1--;

            c1.Display();
            c2.Display();
            c3.Display();
            c4.Display();
            c5.Display();
            c6.Display();

            Console.WriteLine($"{c1 == c2}");
            Console.WriteLine($"{c1 == c1}");
        }
    }

    class ComplexNumber{
        public int real;
        public int imaginary;
        
        public ComplexNumber(int real, int imaginary){
            this.real = real;
            this.imaginary = imaginary;
        }

        public void Display(){
            Console.WriteLine($"{real} + {imaginary} i");
        }

        // + operator overloading for 2 object addition 
        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2){
            int newReal = c1.real + c2.real;
            int newImaginary = c1.imaginary + c2.imaginary;

            ComplexNumber c3 = new ComplexNumber(newReal,newImaginary);
            return c3;
        }

        // + operator overloading for adding an int to an object field
        public static ComplexNumber operator + (ComplexNumber c1, int x){
            int newReal = c1.real + x;
            int newImaginary = c1.imaginary + x;

            ComplexNumber c4 = new ComplexNumber(newReal, newImaginary);
            return c4;
        }

        // - operator overloading for 2 object substractiion
        public static ComplexNumber operator - (ComplexNumber c1, ComplexNumber c2){
            int newReal = c1.real - c2.real;
            int newImaginary = c1.imaginary - c2.imaginary;

            ComplexNumber c5 = new ComplexNumber(newReal, newImaginary);
            return c5;
        }

        //  overloading -- to decrease the value of an object by 1, returns an object 
        public static ComplexNumber operator -- (ComplexNumber c1){
            int newReal = c1.real--;
            int newImaginary = c1.imaginary--;

            ComplexNumber c6 = new ComplexNumber(newReal, newImaginary);
            return c6;
        }

        // overloading == and != to check if two objects are the same, returns true or false
        public static bool operator == (ComplexNumber c1, ComplexNumber c2){
            bool newReal = c1.real == c2.real;
            bool newImaginary = c1.imaginary == c2.imaginary;

            return newReal && newImaginary;
        }

        public static bool operator != (ComplexNumber c1, ComplexNumber c2){
            return !(c1 == c2);
        }
    }

}