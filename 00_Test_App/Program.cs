using System;
using Patterns.StrategyPattern;

namespace Patterns.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			// ---- 1 Strategy Pattern -------------  //
			Dog max = new Dog("Max");
			Bird teddy = new Bird("Teddy");

			Console.WriteLine("==============================");
			Console.WriteLine("Test 1: Strategy Pattern Test");
			Console.WriteLine($"Dog Name is :{max.Name}");
			Console.WriteLine($"Dog Sound is :{max.getSound}");
			Console.WriteLine($"Dog Fly Method is :{max.getFlyType}");
			Console.WriteLine($"Bird Name is :{teddy.Name}");
			Console.WriteLine($"Bird Sound is :{teddy.getSound}");
			Console.WriteLine($"Bird Fly Method is :{teddy.getFlyType}");
		}


	}
}
