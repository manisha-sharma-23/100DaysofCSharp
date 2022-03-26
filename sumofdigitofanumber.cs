using System;

namespace Program
{
	class Program
	{
	
	static void Main(string[] args)
	{
		Console.WriteLine("Please Provide input number");
		int inputNumber = Int32.Parse(Console.ReadLine());
		
		int backValue = inputNumber;
		int sum=0,remainder = 0;
		
		while(inputNumber!=0)
			
			{
				remainder = inputNumber%10;
				sum = sum +remainder;
				inputNumber = inputNumber/10;
			}
			
			Console.WriteLine("Sum of {0} is {1}",backValue,sum);
	}
	}
	
}