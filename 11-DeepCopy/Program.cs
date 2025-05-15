using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A a1 = new A();
            A a2 = new A();
            a1 = a2;
            a1.a= 10;
            a2.a = 28;
            Console.WriteLine(a1.a);
            Console.WriteLine(a2.a);
        }
    }

    class A{
         public int a ;
        
        public A(int n){
            this.n = n;
        }

        // copy constructor

        
    }
}