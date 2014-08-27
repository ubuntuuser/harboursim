//
//  Truck.cs
//
//  Author:
//       Johannes Doblmann <s1310595014@students.fh-hagenberg.at>
//
//  Copyright (c) 2014 Johannes Doblmann, FH Steyr
using System;
using TcpConnectionService;
using System.Collections.Generic;

namespace LegoHarbourSim {
	public class LegoTruck : IVehicle {
		private IPlace currentPlace = LegoPlace.truckStart;
		private ConnectionObject conn;
		public List<IPlace> possiblePlaces;
		private IContainer currContainer = null;

		public LegoTruck () {
			conn = new ConnectionObject("192.168.43.180");
			possiblePlaces = new List<IPlace>();
			possiblePlaces.Add (LegoPlace.truckStart);
			possiblePlaces.Add (LegoPlace.truckInLoadingZone);
		}

		public void goTo(IPlace place) {
			if (possiblePlaces.Contains (place)) {
				conn.sendMessage ("goTo$" + currentPlace.Name + "#" + place.Name);
				currentPlace = place;
			}
		}

		public void wait(int seconds) {
			System.Threading.Thread.Sleep (seconds * 1000);
		}

		public void send(string message) {
			conn.sendMessage (message);
		}
	}
}

