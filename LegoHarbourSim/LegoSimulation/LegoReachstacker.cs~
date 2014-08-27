using System;
using TcpConnectionService;
using System.Collections.Generic;

namespace LegoHarbourSim {
	public class LegoReachstacker : ICrane {
		private IPlace currentPlace = LegoPlace.rsStart;
		private ConnectionObject conn;
		public List<IPlace> possiblePlaces;
		private IContainer currContainer = null;

		public LegoReachstacker () {
			//conn = new ConnectionObject("192.168.43.180");//Truck
			conn = new ConnectionObject("192.168.43.167");//Reachstacker
			possiblePlaces.Add (LegoPlace.rsStart);
		}

		public void pickup(IContainer container) {
			if (container.StoragePlace.Above.Empty) {
				goTo (container.StoragePlace.PlaceInFront);
				container.StoragePlace.clear ();
				container.StoragePlace = null;
				conn.sendMessage ("pickup$" + container.StoragePlace.Level);
				currContainer = container;
			}
		}

		public void drop(IStoragePlace storagePlace) {
			if (storagePlace.Empty && storagePlace.Above.Empty) {
				goTo (storagePlace.PlaceInFront);
				conn.sendMessage ("drop" + storagePlace.Level);
				storagePlace.Container = currContainer;
				storagePlace.Empty = false;
				currContainer = null;
			}
		}

		public void goTo(IPlace place) {
			conn.sendMessage ("goto$" + currentPlace.Name + "#" + place.Name);
			currentPlace = place;
		}

		public void wait(int seconds) {
			System.Threading.Thread.Sleep (seconds * 1000);
		}

		public void send(string message) {
			conn.sendMessage (message);
		}
	}
}

