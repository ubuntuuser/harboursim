using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using LegoRestService;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace LegoHarbourSim {
	class Program {
		static void Main(string[] args) {
//			LegoRestService.LegoRestService LegoServices = new LegoRestService.LegoRestService();
//			WebHttpBinding binding = new WebHttpBinding();
//			//WebHttpBehavior behavior = new WebHttpBehavior();

//			WebServiceHost _serviceHost = new WebServiceHost(LegoServices, new Uri("http://localhost:8000/DEMOService"));
//			_serviceHost.AddServiceEndpoint (typeof(ILegoRestService), binding, "");
//			_serviceHost.Open ();
//			System.Console.WriteLine ("Started Service");
//			Console.ReadKey ();
//			System.Console.WriteLine ("Ended Service");
//			_serviceHost.Close ();
			LegoSimulation sim = new LegoSimulation();
			sim.start ();
		}
	}
}