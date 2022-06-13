using System;
namespace sound
{
	class Program
	{
		public static void Main()
		{
			Normal play = new Normal();
			play.Sound();
			Adapter adapt = new Adapter();
			adapt.Sound();
		}
	}
}