using System;
using AudioToolbox;
using Foundation;
using UIKit;

namespace XamariniOSPlaySound
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		NSUrl url;
		SystemSound ss;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			url = NSUrl.FromFilename("Sounds/enter.aiff");
			ss = new SystemSound(url);
			btnPlay.TouchUpInside += (object sender, EventArgs e) =>
			{
				ss.PlayAlertSound();

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
