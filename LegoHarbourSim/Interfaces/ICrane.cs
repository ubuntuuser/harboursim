using System;

namespace LegoHarbourSim {
	public interface ICrane : IVehicle {
		void pickup(IContainer container);

		void drop(IStoragePlace storagePlace);
	}
}

