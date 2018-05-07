using System;
using Patterns_ObserverPattern.Agregator;

namespace Patterns_ObserverPattern.Widgets {
	
	public class Chanel1Widget : IWidget {
		
		string _chanel1News;

		public void Update(object sender, NewsEventsArgs e) {
			_chanel1News = e.Chanel1News;
			ShowNews();
		}

		public void ShowNews() {
			Console.WriteLine("Chanel 1 news: " + _chanel1News);
		}

	}
}
