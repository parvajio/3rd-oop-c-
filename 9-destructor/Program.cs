using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Sample s = new Sample(23);
    B b = new B(3,5);
  }
}

class Sample{
    public int n;
    
    public Sample(int n){
        this.n = n;
        Console.WriteLine("Constructor is called");
    }
    
    ~Sample(){
        Console.WriteLine("Destructor is called");
    }
}


class A{
    public int n;
    
    public A(int n){
        this.n = n;
    Console.WriteLine("constructor a");
    }
    
    
    ~A(){
        Console.WriteLine("Destructor a");
    }
}

class B:A{
    public int na;
    
    public B(int n,int na):base(n){
        this.na = na;
    Console.WriteLine("constructor b");
    }
    
    
    ~B(){
        Console.WriteLine("Destructor b");
    }
}