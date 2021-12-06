using System;

namespace ExceptionDemo
{
	class Program
	{

		static void ArrayFun()
		{
			int[] nums = new int[] { 3, 6, 9 };
			Console.WriteLine(nums[0]);
			Console.WriteLine(nums[1]);
			Console.WriteLine(nums[2]);
			Console.WriteLine(nums[3]);
		}

		static void CoolFunction()
		{
			Console.WriteLine("This is a cool function!");
		}

		static void Main(string[] args)
		{
			try
			{
				ArrayFun();
				CoolFunction();
			}
			catch (IndexOutOfRangeException oor)
			{
				Console.WriteLine("Oops, we went out of bounds!");
			}

		}
	}
}
