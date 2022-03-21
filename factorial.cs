using System;

namespace CsharpProgram
{
	class factorial
	{
		static int x=1;
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Number");
			int number = Int32.Parse(Console.ReadLine());
			for (int i=number;i>0;i--)
			{
				x=x*i;
				
			}
			
			Console.WriteLine(x);
		}
	}
}
