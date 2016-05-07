using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomTabbedPageRendererSample
{
	public partial class AwesomeTabbedPage : TabbedPage
	{
		public AwesomeTabbedPage ()
		{
			InitializeComponent ();

			for (int i = 0; i < 5; i++) {
				var page = new ContentPage {
					Title = $"Title {i}",
					Content = new StackLayout {
						VerticalOptions = LayoutOptions.Center,
						Children = {
							new Label {
								XAlign = TextAlignment.Center,
								Text = $"Hello from Page {i}"
							}
						}
					}
				};
				Children.Add (page);
			}


		}
	}
}

