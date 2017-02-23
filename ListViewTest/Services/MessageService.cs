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
					MessageTitle = "Message Title 1",
					MessageText = "Message Text 1",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 2,
					MessageTitle = "Message Title 2",
					MessageText = "Message Text 2",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 3,
					MessageTitle = "Message Title 3",
					MessageText = "Message Text 3",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 4,
					MessageTitle = "Message Title 4",
					MessageText = "Message Text 4",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 5,
					MessageTitle = "Message Title 5",
					MessageText = "Message Text 5",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 6,
					MessageTitle = "Message Title 6",
					MessageText = "Message Text 6",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 7,
					MessageTitle = "Message Title 7",
					MessageText = "Message Text 7",
					MessageDate = DateTime.Now

				},
				new Message {
					MessageId = 6,
					MessageTitle = "Message Title 8",
					MessageText = "Message Text 8",
					MessageDate = DateTime.Now

				},

			};

		}
		
	}
}
