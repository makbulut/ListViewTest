using System;
using System.Collections.Generic;
using ListViewTest.Models;

namespace ListViewTest.Services
{
	public class MessageService : BaseService
	{

		public SerachMessageResult getMessages(SearchMessageRequest request)
		{
			var result = new SerachMessageResult();
			result.MessageList = getDummyMessageList();

			return result;
		}

		IList<Message> getDummyMessageList()
		{
			return new List<Message>
			{
				new Message {
					MessageId = 1,
					MessageTitle = "Mesaj Title 1",
					MessageText = "Mesaj Text 1",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 2,
					MessageTitle = "Mesaj Title 2",
					MessageText = "Mesaj Text 2",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 3,
					MessageTitle = "Mesaj Title 3",
					MessageText = "Mesaj Text 3",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 4,
					MessageTitle = "Mesaj Title 4",
					MessageText = "Mesaj Text 4",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 5,
					MessageTitle = "Mesaj Title 5",
					MessageText = "Mesaj Text 5",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 6,
					MessageTitle = "Mesaj Title 6",
					MessageText = "Mesaj Text 6",
					MessageDate = DateTime.Now

				},

			};

		}
		
	}
}
