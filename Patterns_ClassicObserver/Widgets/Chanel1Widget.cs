using System;
using Patterns_ObserverPattern.Agregator;

namespace Patterns_ObserverPattern.Widgets {
	
	public class Chanel1Widget : IObserver, IWidget {

		IAgregator _newsAgregator;
		string _chanel1News;
		
		public Chanel1Widget(IAgregator agregator) {
			_newsAgregator = agregator;
			_newsAgregator.AddObserver(this);
		}

		public void Update(string ch1News, string ch2News) {
			_chanel1News = ch1News;
			ShowNews();
		}
		
		public void RemoveFromAgregator() {
			_newsAgregator.RemoveObserver(this);
		}

		public void ShowNews() {
			Console.WriteLine("Chanel 1 news: " + _chanel1News);
		}

	}
}
