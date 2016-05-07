using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CoreGraphics;

namespace CustomTabbedPageRendererSample.iOS
{
	public class CustomTabButton : UIButton
	{
		readonly UIView _lineView;

		public static int MinimumWidth = 120;

		public bool IsSelected {
			get {
				return TitleLabel.TextColor.ToColor () == CustomColors.Selected;
			}
		}

		public CustomTabButton ()
		{
			Frame = new CGRect (0, 0, MinimumWidth, CustomTabbedPageRenderer.TabHeight);
			BackgroundColor = UIColor.Clear;

			_lineView = new UIView (new CGRect (0, this.Frame.Size.Height - 2, this.Frame.Size.Width, 2));
			_lineView.BackgroundColor = (CustomColors.Inactive.ToUIColor ());

			TitleLabel.Hidden = false;
			TitleLabel.TextColor = (CustomColors.Inactive.ToUIColor ());

			AddSubview (_lineView);
			BringSubviewToFront (_lineView);
			BringSubviewToFront (TitleLabel);
		}

		public void SetButtonSelected ()
		{
			_lineView.BackgroundColor = (CustomColors.Active.ToUIColor ());
			TitleLabel.TextColor = (CustomColors.Selected.ToUIColor());
		}

		public void SetButtonDeselected ()
		{
			_lineView.BackgroundColor = (CustomColors.Inactive.ToUIColor ());
			TitleLabel.TextColor = (CustomColors.Unselected.ToUIColor());
		}

		public void SetButtonWidth (float width)
		{
			this.Frame = new CGRect (this.Frame.X, this.Frame.Y, width, this.Frame.Height);
			_lineView.Frame = new CGRect (_lineView.Frame.X, _lineView.Frame.Y, width, _lineView.Frame.Height);
		}
	}

	public static class CustomColors
	{
		public static Color Active = Color.Red;

		public static Color Inactive = Color.Gray;

		public static Color Selected = Color.Black;

		public static Color Unselected = Color.Gray;
	}
}

