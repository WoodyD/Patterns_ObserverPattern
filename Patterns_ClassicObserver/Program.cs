using System;
using Patterns_ObserverPattern.Agregator;
using Patterns_ObserverPattern.Widgets;

namespace Patterns_ObserverPattern {
	
	class Program {
		
		static void Main(string[] args) {

			NewsAgregator agregator = new NewsAgregator();
			Chanel1Widget ch1Widget = new Chanel1Widget();
			Chanel2Widget ch2Widget = new Chanel2Widget();

			agregator.OnNewsUpdate += ch1Widget.Update;
			agregator.OnNewsUpdate += ch2Widget.Update;

			agregator.NewNewsAwailable();

			agregator.OnNewsUpdate -= ch1Widget.Update;

			agregator.NewNewsAwailable ();

			Console.ReadLine();
			
		}
	}
}
