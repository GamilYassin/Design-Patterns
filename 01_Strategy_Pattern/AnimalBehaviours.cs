using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StrategyPattern
{
	public interface IFlyBehaviour
	{
		string flyMethod();
	}

	public interface ISoundBehaviour
	{
		string getSound();
	}
}

namespace Patterns.StrategyPattern
{
	public class CanFly : IFlyBehaviour
	{
		public string flyMethod()
		{
			return "I Can Fly High";
		}
	}

	public class CanNotFly : IFlyBehaviour
	{
		public string flyMethod()
		{
			return "I Cannot Fly !";
		}
	}

	public class RunFly : IFlyBehaviour
	{
		public string flyMethod()
		{
			return "I can fly only by running";
		}
	}

}


namespace Patterns.StrategyPattern
{
	public class Meaow : ISoundBehaviour
	{
		public string getSound()
		{
			return ("Meaow !!");
		}
	}

	public class Park : ISoundBehaviour
	{
		public string getSound()
		{
			return ("Parking !!");
		}
	}

	public class Neigh: ISoundBehaviour
	{
		public string getSound()
		{
			return ("Neigh !!");
		}
	}

	public class Tweet : ISoundBehaviour
	{
		public string getSound()
		{
			return ("Tweet !!");
		}
	}

}