using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Upper bound value");
			int upperbound = Int32.Parse(Console.ReadLine());
			
			for (int i=1;i<=upperbound;i++)
			{
				int fact = 1;
				for(int j=1;j<=i;j++)
				{
					fact=fact*j;
				}
				Console.WriteLine("{0}! is {1}",i,fact);
			}
		}
	}
}