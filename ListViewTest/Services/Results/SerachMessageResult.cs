using System;
using System.Collections.Generic;
using ListViewTest.Models;

namespace ListViewTest.Services
{
	public class SerachMessageResult : BaseResult
	{
		public IList<Message> MessageList { get; set; }
	}
}
