using System;

namespace LegoHarbourSim {
	public class LegoPlace:IPlace {
		//Reachstacker possible places
		public static LegoPlace rsStart = new LegoPlace("Start");
		public static LegoPlace rsInFrontOfTruck = new LegoPlace("InFrontOfTruck");
		public static LegoPlace rsInFrontOfContainerRow1 = new LegoPlace("InFrontOfContainerRow1");
		public static LegoPlace rsInFrontOfContainerRow2 = new LegoPlace("InFrontOfContainerRow2");
		//Truck possible places
		public static LegoPlace truckStart = new LegoPlace("Start");
		public static LegoPlace truckInLoadingZone = new LegoPlace("InLoadingZone");
		//TODO: add Gantry Crane
		public string Name { get; set; }

		public LegoPlace (string name) {
			this.Name = name;
		}

		public override bool Equals(object obj) {
			if (obj == null)
				return false;
			if (ReferenceEquals (this, obj))
				return true;
			if (obj.GetType () != typeof(LegoPlace))
				return false;
			LegoPlace other = (LegoPlace)obj;
			return Name == other.Name;
		}

		public override int GetHashCode() {
			unchecked {
				return (Name != null ? Name.GetHashCode () : 0);
			}
		}
	}
}

