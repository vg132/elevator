using System.Collections.Generic;

namespace Elevator.Simulation
{
	public class Building
	{
		public IList<Elevator> Elevators { get; } = new List<Elevator>();
		public IList<Floor> Floors { get; } = new List<Floor>();
	}
}