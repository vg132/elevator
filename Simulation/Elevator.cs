using System.Collections.Generic;

namespace Elevator.Simulation
{
	public class Elevator
	{
		public IList<Floor> Stops { get; set; } = new List<Floor>();
		public int WeightLimit { get; set; }
	}
}