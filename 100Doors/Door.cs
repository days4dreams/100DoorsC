using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Doors
{
	class Door
	{
		public Door() { }

		#region Properties
		public bool IsOpen = false;
		public int DoorNumber = 0;
		#endregion

		#region Methods
		public void ChangeStatus(Door door)
		{
			if (this.IsOpen == true)
			{
				this.IsOpen = false;
			}
			else
			{
				this.IsOpen = true;
			}
		}
		#endregion
	}
}
