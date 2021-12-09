using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo2
{
	public class StringHelpers
	{
		// Write a function that reverses a string.
		//    If the function is passed a null, throw an exception.

		public static string Reverse(string str)
		{
			string result = "";
			for (int i = str.Length - 1; i >= 0; i--)
			{
				result += str[i];
			}
			return result;
		}
	}
}
