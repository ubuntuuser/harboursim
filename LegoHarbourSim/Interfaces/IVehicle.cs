using System;

namespace LegoHarbourSim {
	public interface IVehicle {
		void goTo(IPlace place);

		void wait(int seconds);

		void send(string message);
	}
}

