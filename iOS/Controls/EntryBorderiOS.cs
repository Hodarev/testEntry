using CoreAnimation;
using CoreGraphics;
using TestEntry.Controls;
using TestEntry.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryBorder), typeof(EntryBorderiOS))]

namespace TestEntry.iOS
{
	public class EntryBorderiOS : EntryRenderer
	{

		public override void LayoutSubviews()
		{
			base.LayoutSubviews();
			CALayer border = new CALayer();
			float borderWidth = 1;
			border.BorderColor = UIColor.White.CGColor;
			border.Frame = new CGRect(0, this.Frame.Size.Height - borderWidth, this.Frame.Size.Width, this.Frame.Size.Height - borderWidth);
			border.BorderWidth = borderWidth;
			Control.Layer.AddSublayer(border);
			Control.BorderStyle = UITextBorderStyle.None;
			Control.Layer.MasksToBounds = true;

		}
	}
}
