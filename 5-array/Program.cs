using System;
class HelloWorld {
	static void Main() {
		double[] dbl = {12.22,23.56,2.46};
		foreach(double db in dbl) {

			Console.WriteLine(db);
		}
		
		//taking input
		
		double[] height = new double[5];
		
		for(int i = 0; i<5; i++){
		    string inputHieght = Console.ReadLine();
		    height[i] = Convert.ToDouble(inputHieght);
		    Console.WriteLine(height[i]);
		}
	}
}