using System;
using System.Linq;

namespace Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			var building = new Simulation.Building();

			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });
			building.Floors.Add(new Simulation.Floor { CommercialOccupants = 100, ResidentialOccupants = 0 });

			building.Elevators.Add(new Simulation.Elevator { WeightLimit = 1000, Stops = building.Floors });



			while(true)
			{

			}




			Console.WriteLine("Hello World!");
		}
	}
}