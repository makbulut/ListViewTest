using ListViewTest.ViewModels;
using Xamarin.Forms;

namespace ListViewTest.Views
{
	public partial class MessagesPage : ContentPage
	{
		MessagesViewModel _viewModel = null;

		public MessagesPage()
		{
			InitializeComponent();

			_viewModel = new MessagesViewModel();
			BindingContext = _viewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.LoadData();
		}
	}
}
