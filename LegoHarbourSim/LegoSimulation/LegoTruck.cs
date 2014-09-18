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
using System.Threading;

namespace LegoHarbourSim {
	public class LegoTruck : IVehicle {
		private String ipAddress = "10.0.0.5";
		private IPlace currentPlace = LegoPlace.truckStart;
		private ConnectionObject conn;
		public List<IPlace> possiblePlaces;
		private IContainer currContainer = null;

		public LegoTruck () {
			while (!tryConnect ()) {
				Console.WriteLine ("Trying to connect to the truck...");
				Thread.Sleep (1000);
			}
			Console.WriteLine (">> Truck connected");
			possiblePlaces = new List<IPlace> ();
			possiblePlaces.Add (LegoPlace.truckStart);
			possiblePlaces.Add (LegoPlace.truckInLoadingZone);
		}

		public LegoTruck (String ipAddress) {
			this.ipAddress = ipAddress;
			while (!tryConnect ()) {
				Console.WriteLine ("Trying to connect to the truck...");
				Thread.Sleep (1000);
			}
			Console.WriteLine (">> Truck connected");
			possiblePlaces = new List<IPlace> ();
			possiblePlaces.Add (LegoPlace.truckStart);
			possiblePlaces.Add (LegoPlace.truckInLoadingZone);
		}

		public void goTo (IPlace place) {
			if (possiblePlaces.Contains (place)) {
				conn.sendMessage ("goTo$" + currentPlace.Name + "#" + place.Name);
				currentPlace = place;
			}
		}

		public void wait (int seconds) {
			System.Threading.Thread.Sleep (seconds * 1000);
		}

		public void send (string message) {
			conn.sendMessage (message);
		}

		public bool tryConnect () {
			try {
				conn = new ConnectionObject (ipAddress);
			} catch (Exception e) {
				Console.WriteLine ("Caught exception: " + e.Message);
				return false;
			}
			return true;
		}
	}
}

