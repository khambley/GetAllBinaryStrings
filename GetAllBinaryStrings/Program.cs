using System;
using System.Collections.Generic;

namespace GetAllBinaryStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(get_all_binary_strings(3));
		}
		public static List<List<string>> get_all_binary_strings(int n)
		{
			List<List<string>> result = new List<List<string>>();

			List<string> slate = new List<string>();

			helper(n, slate, result);

			return result;
		}
		public static void helper(int n, List<string> slate, List<List<string>> result)
		{
			if(slate.Count <= n)
			{
				if (n == slate.Count)
				{
					result.Add(slate);
				}
				else
				{
					slate.Add("0");
					helper(n, slate, result);
					slate.Add("1");
					helper(n, slate, result);
				}
			}
			
		}
		
	}
}
