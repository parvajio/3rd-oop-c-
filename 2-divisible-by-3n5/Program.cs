using System;
class HelloWorld {
	static void Main() {
		int num = 2;
		if(num%3 == 0 && num%5 == 0) {
			Console.WriteLine($"this {num} is divisible by 3 & 5");
		}
		else {
			if(num%3 == 0) {
				Console.WriteLine($"this {num} is divisible by 3");
			}
			else if (num%5 == 0) {
                Console.WriteLine($"this {num} is divisible by 5");
			}
			else{
			    Console.WriteLine($"this {num} is not divisible by 3 or  5");
			}
		}
	}
}