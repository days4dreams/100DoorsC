using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Doors
{
	class Program
	{
		static void Main(string[] args)
		{
			User user = new User();

			Console.WriteLine("Welcome to 100 Doors \r\n");
			Console.WriteLine("100 Doors in a row are closed...  You make 100 passes by the doors.");
			Console.WriteLine("The first time through, you visit every door and toggle the door... until you only visit the 100th door.");
			Console.WriteLine("After all the passes; How many doors are open? How many are closed? \r\n Press ENTER key to continue");
			Console.ReadLine();

			user.CreateDoors();
			user.PassByDoors(user.Count);
			user.DetermineDoorStatus();

			Console.WriteLine("There are {0} doors open", user.NumberOfDoorsOpen);
			Console.WriteLine("There are {0} doors closed", user.NumberOfDoorsClosed);
			Console.ReadLine();

		}
	}
}
