using System;

namespace LegoHarbourSim {
	public class LegoSimulation : ISimulation {
		IVehicle truck = new LegoTruck ();
		//		IVehicle reachstacker = new LegoReachstacker ();
		//		IVehicle gc = new LegoGantryCrane ();

		public LegoSimulation () {


		}

		public bool initialize () {
			return true;
		}

		public void start () {
			string s = String.Empty;
			while (s != "stop") {
				Console.WriteLine ("Type message to send");
				s = Console.ReadLine ();
				if (s == "stop")
					break;

				truck.send (s);
//				reachstacker.send (s);
//				gc.send (s);
				Console.WriteLine ("Sent message");
			}
		}
	}
}

