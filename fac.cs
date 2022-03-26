using System;

namespace Factorial
{
	class Fact
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please Provide Factorial Number");
			int number = Int32.Parse(Console.ReadLine());
			int result = factorial(number);
			Console.WriteLine(result);
			
			
		}
		
			static int fact = 1;
			private static int factorial(int number)
			{
				if(number>0)
				{
					fact = number*factorial(number-1);
				}
				return fact;
			}
			
		
	}
}