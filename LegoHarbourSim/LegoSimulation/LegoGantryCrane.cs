//
//  GantryCrane.cs
//
//  Author:
//       Johannes Doblmann <s1310595014@students.fh-hagenberg.at>
//
//  Copyright (c) 2014 Johannes Doblmann
using System;
using TcpConnectionService;
using System.Threading;

namespace LegoHarbourSim {
	public class LegoGantryCrane :ICrane {
		private ConnectionObject conn;
		private String ipAddress = "10.0.0.3";

		public LegoGantryCrane () {
			while (!tryConnect ()) {
				Console.WriteLine ("Trying to connect to the gantry crane...");
				Thread.Sleep (1000);
			}
		}

		public LegoGantryCrane (String ipAddress) {
			this.ipAddress = ipAddress;
			while (!tryConnect ()) {
				Console.WriteLine ("Trying to connect to the gantry crane...");
				Thread.Sleep (1000);
			}
		}

		public void pickup (IContainer container) {
			throw new NotImplementedException ();
		}

		public void drop (IStoragePlace storagePlace) {
			throw new NotImplementedException ();
		}

		public void goTo (IPlace place) {
			throw new NotImplementedException ();
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