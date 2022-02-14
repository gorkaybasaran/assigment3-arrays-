using System;
using System.Linq;

public class Program
{

	public static void Main()
	{
		Console.WriteLine("Enter integer n number");
		int n = Convert.ToInt32(Console.ReadLine());
		var prime = new int[n];

		for (int i = 0; i < n; i++) prime[i] = i + 1;

		prime = prime.Where((v, ind) => ind != 0).ToArray();
		n--;

		for (int i = 0; i < n; i++)
		{

			for (int j = (i + 1); j < n; j++)
			{
				if (prime[j] % prime[i] == 0)
				{
					prime = prime.Where((v, ind) => ind != j).ToArray();
					n--;
				}
			}
		}


		//Print Prime Number
		Console.Write("Result: ");
		for (int i = 0; i < n; i++)
		{
			Console.Write(prime[i] + ",");
		}
		Console.Write("End");
	}
}