using System;
using System.Collections.Generic;
using Patterns_ObserverPattern.Widgets;

namespace Patterns_ObserverPattern.Agregator {
	
	public class NewsAgregator : IAgregator{

		List<IObserver> _observers;
		Random _rnd;
		
		public NewsAgregator() {
			_rnd = new Random();
			_observers = new List<IObserver>();
		}

		public void AddObserver(IObserver observer) {
			_observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer) {
			_observers.Remove(observer);
		}
		
		public void NotifyObservers() {
			string chanel1News = GetChanel1News();
			string chanel2News = GetChanel2News();

			for (int i = 0; i < _observers.Count; i++)
				_observers[i].Update(chanel1News, chanel2News);
			
		}
		
		public void NewNewsAwailable(){
			NotifyObservers();
		}
		
		private string GetChanel1News(){
			List<string> chNews = new List<string> {
				"News 1 from chanel 1",
				"News 2 from chanel 1",
				"News 3 from chanel 1"
			};

			return chNews[_rnd.Next(0, 2)];
		}

		private string GetChanel2News() {
			List<string> chNews = new List<string> { 
				"News 1 from chanel 2",
				"News 2 from chanel 2",
				"News 3 from chanel 2"
			};
			
			return chNews[_rnd.Next(0,2)];
		}
		
	}
}
