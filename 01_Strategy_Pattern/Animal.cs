using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StrategyPattern
{
	public class Animal
	{

		public string Name { get; set; }
		public double Height { get; set; }
		public int Weight { get; set; }
		public string  favFood { get; set; }
		public string speed { get; private set; }

		protected ISoundBehaviour sound { get; set; }
		protected IFlyBehaviour flyType{ get; set; }

		public string getSound {get { return sound.getSound(); } }
		public string getFlyType { get { return flyType.flyMethod(); } }

		public Animal(string name)
		{
			this.Name = name;
		}


	}
}
