using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StrategyPattern
{
	public class Bird: Animal
	{

		public Bird(string birdName) : base(birdName)
		{
			this.sound = new Tweet();
			this.flyType = new CanFly();
		}

	}
}
