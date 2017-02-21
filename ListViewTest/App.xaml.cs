﻿using ListViewTest.Views;
using Xamarin.Forms;

namespace ListViewTest
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MessagesPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
