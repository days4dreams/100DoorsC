using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Doors
{
	class User
	{
		public User()
		{
			Initalise();
		}
		public void Initalise()
		{
			this.NumberOfDoorsClosed = 0;
			this.NumberOfDoorsOpen = 0;
			this.Count = 1;
			this.listOfDoors = new List<Door>();
		}

			public int NumberOfDoorsClosed;
			public List<Door> listOfDoors;
			public int Count;
			public int NumberOfDoorsOpen;

		public void CreateDoors()
		{
			for (int i = 1; i < 101; i++)
			{
				Door aDoor = new Door();
				aDoor.DoorNumber = i;
				listOfDoors.Add(aDoor);
			}
		}

		public void PassByDoors(int Count)
		{
			while(Count < 101)
			{
				foreach (Door door in listOfDoors)
				{
					if (door.DoorNumber % Count == 0)
					{
						door.ChangeStatus(door);
					};
				}
				Count++;
			}
		}

		public void DetermineDoorStatus()
		{
			foreach (Door door in listOfDoors)
			{
				if (door.IsOpen)
				{
					NumberOfDoorsOpen++;
				}
				else
				{
					NumberOfDoorsClosed++;
				}
			}
		}
	}
}
