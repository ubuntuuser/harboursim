//
//  StoragePlace.cs
//
//  Author:
//       Johannes Doblmann <s1310595014@students.fh-hagenberg.at>
//
//  Copyright (c) 2014 Johannes Doblmann, FH Steyr
using System;

namespace LegoHarbourSim {
	public class LegoStoragePlace:IStoragePlace {
		static LegoStoragePlace None = new LegoStoragePlace();

		private LegoStoragePlace () {
			Empty = true;
			Container = null;
			Above = LegoStoragePlace.None;
			Underneath = LegoStoragePlace.None;
			PlaceInFront = null;
			Level = 1;
		}

		public LegoStoragePlace (IPlace placeInFront) {
			Above = LegoStoragePlace.None;
			Underneath = LegoStoragePlace.None;
			PlaceInFront = placeInFront;
			Empty = true;
			Container = null;
			Level = 1;
		}

		public LegoStoragePlace (IPlace placeInFront, IContainer container) {
			Above = LegoStoragePlace.None;
			Underneath = LegoStoragePlace.None;
			PlaceInFront = placeInFront;
			Empty = false;
			Container = container;
			Level = 1;
		}

		public LegoStoragePlace (IStoragePlace above, IStoragePlace underneath, IPlace placeInFront) {
			Above = above;
			Underneath = underneath;
			PlaceInFront = placeInFront;
			Empty = true;
			Container = null;
			Level = 1;
		}

		public LegoStoragePlace (IStoragePlace above, IStoragePlace underneath, IPlace placeInFront, int level) {
			Above = above;
			Underneath = underneath;
			PlaceInFront = placeInFront;
			Empty = true;
			Container = null;
			Level = level;
		}

		public LegoStoragePlace (IStoragePlace above, IStoragePlace underneath, IPlace placeInFront, IContainer container) {
			Above = above;
			Underneath = underneath;
			PlaceInFront = placeInFront;
			Empty = false;
			Container = container;
			Level = 1;
		}

		public LegoStoragePlace (IStoragePlace above, IStoragePlace underneath, IPlace placeInFront, IContainer container, int level) {
			Above = above;
			Underneath = underneath;
			PlaceInFront = placeInFront;
			Empty = false;
			Container = container;
			Level = level;
		}

		public void clear() {
			Container = null;
			Empty = true;
		}

		public int Level { set; get; }

		public bool Empty { get; set; }

		public IContainer Container { get; set; }

		public IStoragePlace Underneath { get; set; }

		public IStoragePlace Above { get; set; }

		public IPlace PlaceInFront { get; set; }
	}
}

