//
//  LegoReachstacker.cs
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
	public class LegoReachstacker : ICrane {
		private IPlace currentPlace = LegoPlace.rsStart;
		private ConnectionObject conn;
		public List<IPlace> possiblePlaces = new List<IPlace> ();
		private IContainer currContainer = null;
		private String ipAddress = "10.0.0.4";

		public LegoReachstacker () {
			while (!tryConnect ()) {
				Console.WriteLine (">> Trying to connect to the Reachstacker...");
				Thread.Sleep (1000);
			}
			Console.WriteLine (">> Reachstacker connected");
			possiblePlaces.Add (LegoPlace.rsStart);
		}

		public LegoReachstacker (String ipAddress) {
			this.ipAddress = ipAddress;
			while (!tryConnect ()) {
				Console.WriteLine ("Trying to connect to the Reachstacker...");
				Thread.Sleep (1000);
			}
			Console.WriteLine (">> Reachstacker connected");
		}

		public void pickup (IContainer container) {
			if (container.StoragePlace.Above.Empty) {
				goTo (container.StoragePlace.PlaceInFront);
				container.StoragePlace.clear ();
				container.StoragePlace = null;
				conn.sendMessage ("pickup$" + container.StoragePlace.Level);
				currContainer = container;
			}
		}

		public void drop (IStoragePlace storagePlace) {
			if (storagePlace.Empty && storagePlace.Above.Empty) {
				goTo (storagePlace.PlaceInFront);
				conn.sendMessage ("drop" + storagePlace.Level);
				storagePlace.Container = currContainer;
				storagePlace.Empty = false;
				currContainer = null;
			}
		}

		public void goTo (IPlace place) {
			conn.sendMessage ("goto$" + currentPlace.Name + "#" + place.Name);
			currentPlace = place;
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
				return false;
			}
			return true;
		}
	}
}

