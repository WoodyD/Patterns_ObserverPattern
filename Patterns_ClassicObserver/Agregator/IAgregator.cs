namespace Patterns_ObserverPattern.Agregator {
	
	public interface IAgregator {

		void AddObserver(Widgets.IObserver observer);
		void RemoveObserver(Widgets.IObserver observer);
		void NotifyObservers();
		
	}
}
