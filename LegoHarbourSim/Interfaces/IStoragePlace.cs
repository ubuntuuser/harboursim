//
//  IStoragePlace.cs
//
//  Author:
//       Johannes Doblmann <s1310595014@students.fh-hagenberg.at>
//
//  Copyright (c) 2014 Johannes Doblmann, FH Steyr
using System;

namespace LegoHarbourSim {
	public interface IStoragePlace {
		bool Empty { get; set; }

		IContainer Container{ set; get; }

		IStoragePlace Underneath { set; get; }

		IStoragePlace Above { set; get; }

		IPlace PlaceInFront { set; get; }

		int Level { get; set; }

		void clear();
	}
}

