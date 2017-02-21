using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewTest.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{

		bool _isBusy = false;
		public bool IsBusy
		{
			set { SetProperty(ref _isBusy, value); }
			get { return _isBusy; }
		}

		bool _isVisible = true;
		public bool IsVisible
		{
			set { SetProperty(ref _isVisible, value); }
			get { return _isVisible; }
		}

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			storage = value;

			OnPropertyChanged(propertyName);

			return true;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
