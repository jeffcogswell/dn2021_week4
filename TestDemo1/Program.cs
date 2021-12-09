using System;

namespace TestDemo1
{
	class Program
	{

		// Suppose we want a function that takes three integers and returns the sum.

		static int SumThree(int x, int y, int z)
		{
			return x + y - z;
		}

		// Write a function that reverses a string.
		//    If the function is passed a null, throw an exception.

		static string Reverse(string str)
		{
			string result = "";
			for (int i=str.Length - 1; i >= 0; i--)
			{
				result += str[i];
			}
			return result;
		}

		static void Main(string[] args)
		{

			string test1 = "hello";
			string result1 = Reverse(test1); // Expect olleh
			if (result1 == "olleh")
			{
				Console.WriteLine("Test1 passed!");
			}
			else
			{
				Console.WriteLine($"Test1 failed! Expected olleh but actual was {result1}");
			}

			string test2 = "";
			string result2 = Reverse(test2); // Expectd empty string
			if (result2 == "")
			{
				Console.WriteLine("Test2 passed!");
			}
			else
			{
				Console.WriteLine($"Test1 failed! Expected empty string but actual was {result2}");
			}

			string test3 = null;
			try
			{
				string result3 = Reverse(test3); // exepct null
				if (result3 == null)
				{
					Console.WriteLine("Test3 failed!");
				}
				else
				{
					Console.WriteLine($"Test3 failed! Expected null but actual was {result3}");
				}
			}
			catch
			{
				Console.WriteLine("Test3 passed with an exception!");
			}

			Console.WriteLine("All done!");

			//int test1 = SumThree(0, 0, 0); // Expect 6
			//if (test1 == 0)
			//{
			//	Console.WriteLine($"test1 passed! Expected 6 and the actual was {test1}");
			//}
			//else
			//{
			//	Console.WriteLine($"test1 failed! Expected 6 but the actual was {test1}");
			//}

			//Console.WriteLine(SumThree(1, 2, 3)); // Expect 6
			//Console.WriteLine(SumThree(2, 2, 2)); // Expect 6
		}
	}
}
