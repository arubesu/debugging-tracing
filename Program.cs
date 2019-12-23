using System;
using System.Diagnostics;

namespace debugger_tracing
{
	class Program
	{
		static void Main(string[] args)
		{
			CounterToN(10);
		}


		/// <summary>
		/// This Method is only executed in Debug mode
		/// </summary>
		/// <param name="n"></param>
		[Conditional("Debug")]
		static void CounterToN(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
