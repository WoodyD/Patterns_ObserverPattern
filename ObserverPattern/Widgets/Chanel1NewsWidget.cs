using System;

namespace ObserverPattern.Widgets {
	class Chanel1NewsWidget : INewsWidget {

		private string _news;

		public void UpdateNews () {
			
		}

		public void DisplayNews () {
			Console.WriteLine ("Chanel 1 news: " + _news);
		}
	}
}
