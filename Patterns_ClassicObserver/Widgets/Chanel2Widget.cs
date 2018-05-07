using System;
using Patterns_ObserverPattern.Agregator;

namespace Patterns_ObserverPattern.Widgets {
	
	public class Chanel2Widget : IObserver, IWidget {

		IAgregator _newsAgregator;
		string _chanel2News;
		
		public Chanel2Widget(IAgregator agregator) {
			_newsAgregator = agregator;
			_newsAgregator.AddObserver(this);
		}

		public void Update(string ch1News, string ch2News) {
			_chanel2News = ch2News;
			ShowNews();
		}
		
		public void RemoveFromAgregator() {
			_newsAgregator.RemoveObserver(this);
		}

		public void ShowNews() {
			Console.WriteLine("Chanel 2 news: " + _chanel2News);
		}

	}
}
