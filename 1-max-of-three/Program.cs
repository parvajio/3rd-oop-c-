using System;

class Program
{
    static void Main()
    {
        
       int a = 23;
       int b= 34;
       int c = 234;
       int max = a;
       
       if(b > max ){
           max = b;
       }
       
       if(c > max){
           max = c;
       }
      
        Console.WriteLine("The maximum number is: " + max);
    }
}
