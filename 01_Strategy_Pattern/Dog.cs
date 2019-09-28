using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StrategyPattern
{
	public class Dog: Animal
	{
		public Dog(string dogName): base(dogName)
		{
			this.sound = new Park();
			this.flyType = new CanNotFly();
		}

	}
}
