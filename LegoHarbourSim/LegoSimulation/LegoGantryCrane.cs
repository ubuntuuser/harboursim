//
//  GantryCrane.cs
//
//  Author:
//       Johannes Doblmann <s1310595014@students.fh-hagenberg.at>
//
//  Copyright (c) 2014 Johannes Doblmann
using System;
using TcpConnectionService;

namespace LegoHarbourSim {
	public class LegoGantryCrane :ICrane {
		public LegoGantryCrane () {
		}

		public void pickup(IContainer container) {
			throw new NotImplementedException();
		}

		public void drop(IStoragePlace storagePlace) {
			throw new NotImplementedException();
		}

		public void goTo(IPlace place) {
			throw new NotImplementedException();
		}

		public void wait(int seconds) {
			System.Threading.Thread.Sleep (seconds * 1000);
		}

		public void send(string message) {
			//TODO implement
		}
	}
}

