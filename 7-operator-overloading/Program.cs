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

            c1.Display();
            c2.Display();
            c3.Display();
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
            Console.WriteLine($"{real} + {imaginary}i");
        }

        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2){
            int newReal = c1.real + c2.real;
            int newImaginary = c1.imaginary + c2.imaginary;

            ComplexNumber c3 = new ComplexNumber(newReal,newImaginary);
            return c3;
        }
    }

}