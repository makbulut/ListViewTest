using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ListViewTest.Models;
using ListViewTest.Services;
using Xamarin.Forms;

namespace ListViewTest.ViewModels
{
	public class MessagesViewModel : BaseViewModel
	{
		MessageService _messageService = new MessageService();

		public ObservableCollection<Message> MessageList { set; get; }

		public SearchMessageRequest request;

		public string TestText
		{
			get { return "Text from ViewModel property which is binded to ListView !"; }
		}


		public ICommand CommandReadMessage
		{
			get { return new Command<Message>(ReadMessage); }
		}

		public ICommand CommandAnswerMessage
		{
			get { return new Command<Message>(AnswerMessage); }
		}



		public MessagesViewModel()
		{
			MessageList = new ObservableCollection<Message>();
		}

		public void LoadData()
		{
			if (MessageList.Count == 0)
			{
				request = new SearchMessageRequest();
				Task.Run(async () => await LoadMessageList());
			}
		}



		#region buton actions

		void ReadMessage(Message item)
		{
			Application.Current.MainPage.DisplayAlert("", "Clicked read button", "OK");
		}
		void AnswerMessage(Message item)
		{
			Application.Current.MainPage.DisplayAlert("", "Clicked answer button", "OK");
		}


		#endregion buton actions

		async Task LoadMessageList()
		{
			IsBusy = true;

			var result = _messageService.getMessages(request);
			var messages = result.MessageList;



			if (messages != null)
			{
				foreach (var item in messages)
				{
					MessageList.Add(item);
				}
			}

			IsBusy = false;
		}

	}
}