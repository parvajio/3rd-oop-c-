using System;
class HelloWorld {
  static void Main() {
      char x = 'y';
      
      if(char.IsLetter(x)){
          Console.WriteLine("This is a alphabet.");
      }
      else{
          Console.WriteLine("This is not a alpha");
      }
  }
}