using System;
using Patterns_ObserverPattern.Agregator;

namespace Patterns_ObserverPattern.Widgets {
	
	public class Chanel2Widget : IWidget {

		string _chanel2News;
		
		public void Update(object sender, NewsEventsArgs e) {
			_chanel2News = e.Chanel2News;
			ShowNews();
		}

		public void ShowNews() {
			Console.WriteLine("Chanel 2 news: " + _chanel2News);
		}

	}
}
