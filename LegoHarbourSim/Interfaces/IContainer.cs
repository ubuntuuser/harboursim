using System;

namespace LegoHarbourSim {
	public interface IContainer {
		IStoragePlace StoragePlace { set; get; }

		String name { set; get; }

		int Level{ set; get; }
		//Level 1: ground
		bool onCrane { set; get; }
	}
}

