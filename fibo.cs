using System;

namespace CSharpProgram
{
	class fibo
	{	
		static int p1=0,p2=1,p3;
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the input values");
			int count = Int32.Parse(Console.ReadLine());
			Console.WriteLine(p1 + " " + p2);
			for (int i=0;i<count;i++)
			Fibonacci(count-2);
		
			
		}
		private static void Fibonacci(int count)
		{
			if(count>0)
			{
				p3=p1+p2;
				Console.WriteLine(" "+p3);
				p1=p2;
				p2=p3;
				Fibonacci(count-1);
			}
		}
	}
}