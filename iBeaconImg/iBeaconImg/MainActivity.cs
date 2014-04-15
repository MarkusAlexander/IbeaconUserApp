using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Views.Animations;


namespace iBeaconImg
{

	[Activity (Label = "BeaconScan", MainLauncher = true)]
	public class MainActivity : Activity
	{
		Trilateration tr = new Trilateration();
		//RelativeLayout.LayoutParams par;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			var dot = FindViewById<ImageView> (Resource.Id.demoImageView);
			dot.SetImageResource(Resource.Drawable.positionCursor);


			var b1 = new iBeacon();
			var b2 = new iBeacon();
			var b3 = new iBeacon();

			b1.Distance = 3;
			b2.Distance = 3;
			b3.Distance = 3;

<<<<<<< HEAD
			b1.RSSI = -40;
			b2.RSSI = -40;
			b3.RSSI = -40;

=======
>>>>>>> 52a1c195c6dc4b591857e0dbaf956a2dab4ab9a9
			b1.X = 200;
			b1.Y = 100;
			b2.X = 290;
			b2.Y = 520;
			b3.X = 20;
			b3.Y = 1000;

			var dotpos = tr.Trilaterate (b1, b2, b3);
<<<<<<< HEAD
			dot.Left = unchecked((int)dotpos.X);
			dot.Top = unchecked((int)dotpos.Y);
=======

			//Din mamma <3
>>>>>>> 52a1c195c6dc4b591857e0dbaf956a2dab4ab9a9

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//AbsoluteLayout.LayoutParams param = new AbsoluteLayout.LayoutParams (10, 10, 100, 200);
			//dot.setLayoutParam(param);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {

			};
		}
	}
}




