using System;
using System.Collections.Generic;
using System.Windows.Input;
using ListViewTest.ViewModels;
using Xamarin.Forms;

namespace ListViewTest
{
	public partial class CustomCell : ViewCell
	{

		public static readonly BindableProperty ParentBindingContextProperty =
			BindableProperty.Create(nameof(ParentBindingContext), typeof(IViewModel), typeof(CustomCell));


		public IViewModel ParentBindingContext
		{
			get { return (IViewModel)GetValue(ParentBindingContextProperty); }
			set { 
				SetValue(ParentBindingContextProperty, value); 
			}
		}


		public CustomCell()
		{
			InitializeComponent();
		}
	}
}
