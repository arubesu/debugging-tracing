using System;
using System.Diagnostics;

namespace debuggertracing
{
	class Program
	{
		static void Main(string[] args)
		{
			BuildTraceListener();

			CounterToN(10);
		}

		private static void BuildTraceListener()
		{
			var traceListener = new TextWriterTraceListener("filename.txt");
			Trace.AutoFlush = true;
			Trace.Listeners.Add(traceListener);
		}

		static void ConditionalCompiler()
		{
#if Debug_01
#warning "This is an Warning Message"
#error "This line break Application"
#endif
		}


		/// <summary>
		/// This Method is only executed in Debug mode
		/// </summary>
		/// <param name="n"></param>
		[Conditional("DEBUG")]
		static void CounterToN(int n)
		{
			Trace.WriteLine($"Starting CounterToN");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(i);
				Trace.WriteLine(i);
			}
		}

		[Obsolete("This method is obsolete, use y instead")]
		static void ObsoleteMethod(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(i);
			}

		}

		[DebuggerStepThrough]
		static void PrintToConsole()
		{
			Console.WriteLine("Hello world!");
		}
	}
}
