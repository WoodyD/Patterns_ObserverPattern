using System;
using Patterns_ObserverPattern.Agregator;
using Patterns_ObserverPattern.Widgets;

namespace Patterns_ObserverPattern {
	
	class Program {
		
		static void Main(string[] args) {

			IAgregator agregator = new NewsAgregator();
			IObserver ch1Widget = new Chanel1Widget(agregator);
			IObserver ch2Widget = new Chanel2Widget(agregator);

			agregator.NotifyObservers();

			//agregator.RemoveObserver(ch1Widget);
			// or
			ch2Widget.RemoveFromAgregator();

			agregator.NotifyObservers();
			
			Console.ReadLine();
			
		}
	}
}
