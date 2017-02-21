using System;
using ListViewTest.Models;
using Xamarin.Forms;

namespace ListViewTest.Helpers
{
	public class MessagesDataTemplateSelector : DataTemplateSelector
	{
		readonly DataTemplate customCellTemplate = new DataTemplate(typeof(CustomCell));

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var type = item.GetType();

			switch (type.Name)
			{
				case nameof(Message):
				default:
					return customCellTemplate;
			}
		}
	}
}
