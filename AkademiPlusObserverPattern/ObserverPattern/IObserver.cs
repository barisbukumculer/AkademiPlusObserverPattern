using AkademiPlusObserverPattern.DAL;

namespace AkademiPlusObserverPattern.ObserverPattern
{
	public interface IObserver
	{
		void CreateNewUser(AppUser appUser);
	}
}
