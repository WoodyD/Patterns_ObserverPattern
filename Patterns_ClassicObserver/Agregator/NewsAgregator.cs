using System;
using System.Collections.Generic;
using Patterns_ObserverPattern.Widgets;

namespace Patterns_ObserverPattern.Agregator {

	public class NewsEventsArgs {

		public string Chanel1News { get; private set; }
		public string Chanel2News { get; private set; }

		public NewsEventsArgs (string ch1News, string ch2News) {
			Chanel1News = ch1News;
			Chanel2News = ch2News;
		}
	}

	public delegate void NewsChangetEventHandler (object sender, NewsEventsArgs e);

	public class NewsAgregator{

		public event NewsChangetEventHandler OnNewsUpdate;

		Random _rnd;
		
		public NewsAgregator() {
			_rnd = new Random();
		}
		
		public void NewNewsAwailable(){
			string chanel1News = GetChanel1News ();
			string chanel2News = GetChanel2News ();

			//if (OnNewsUpdate != null)
			//	OnNewsUpdate (this, new NewsEventsArgs(chanel1News, chanel2News));
			// best way
			OnNewsUpdate?.Invoke (this, new NewsEventsArgs (chanel1News, chanel2News));
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
