using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("1. Open Menu");
		Console.WriteLine("2. Make payment");
		Console.WriteLine("3. Order Placed");
		Console.WriteLine("4. Comlete payment");
		Console.WriteLine("0. Exit..\n");
		while(true) {
			int input =  Convert.ToInt32(Console.ReadLine());

			if(input == 1) {
				Console.WriteLine("You selected: the menu\n");
			}
			else if (input == 2) {
				Console.WriteLine("You selected: the payment\n");
			}
			else if (input == 3) {
				Console.WriteLine("You selected: order placed\n");
			}
			else if (input == 4) {
				Console.WriteLine("You selected: complete payment\n");
			}
			else if (input == 0) {
				Console.WriteLine("You exiting ...\n");
				return;
			}
			else {
				Console.WriteLine("Wrong input\n");
			}
		}

	}
}