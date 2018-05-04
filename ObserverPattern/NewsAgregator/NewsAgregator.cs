using System;

namespace ObserverPattern.NewsAgregator {

	public class AllNewsChanelsEventArgs {
		public string Chanel1News { get; private set; }
		public string Chanel2News { get; private set; }
		public string Chanel3News { get; private set; }

		public AllNewsChanelsEventArgs (string ch1News, string ch2News, string ch3News) {
			Chanel1News = ch1News;
			Chanel2News = ch2News;
			Chanel3News = ch3News;
		}
	}

	public delegate void NewsChangedEventHandler (object sender, AllNewsChanelsEventArgs e);

	public class NewsAgregator {
		public event NewsChangedEventHandler OnNewsChanged;

		public NewsAgregator () {
			GetNews ();
		}

		private void GetNews () {
			throw new NotImplementedException ();
		}
	}

	internal class SomeNews {
		string ch1News1 = "BlaBla 1 from Chanel 1";
		string ch1News2 = "BlaBla 2 from Chanel 1";
		string ch1News3 = "BlaBla 3 from Chanel 1";
		string ch2News1 = "BlaBla 1 from Chanel 2";
		string ch2News2 = "BlaBla 2 from Chanel 2";
		string ch2News3 = "BlaBla 3 from Chanel 2";
		string ch3News1 = "BlaBla 1 from Chanel 2";
		string ch3News2 = "BlaBla 2 from Chanel 2";
		string ch3News3 = "BlaBla 3 from Chanel 2";

		public void GetRandomNews () {

		}

	}
}
