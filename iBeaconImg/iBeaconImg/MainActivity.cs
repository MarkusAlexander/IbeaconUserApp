﻿using System;
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
<<<<<<< HEAD
			//var dot = FindViewById<ImageView> (Resource.Id.demoImageView);
			//dot.SetImageResource(Resource.Drawable.positionCursor);
=======

>>>>>>> ff5956e66caeda86e5b7e657aacc4e1e31a1201d


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
			b1.RSSI = -50;
			b2.RSSI = -50;
			b3.RSSI = -50;
>>>>>>> ff5956e66caeda86e5b7e657aacc4e1e31a1201d

			b1.X = 200;
			b1.Y = 100;
			b2.X = 290;
			b2.Y = 520;
			b3.X = 20;
			b3.Y = 1000;

			var dotpos = tr.Trilaterate (b1, b2, b3);
<<<<<<< HEAD
			//dot.Left = unchecked((int)dotpos.X);
			//dot.Top = unchecked((int)dotpos.Y);
=======


			//Din mamma <3
>>>>>>> ff5956e66caeda86e5b7e657aacc4e1e31a1201d

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//AbsoluteLayout.LayoutParams param = new AbsoluteLayout.LayoutParams (10, 10, 100, 200);
			//dot.setLayoutParam(param);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
<<<<<<< HEAD
				var dot = FindViewById<ImageView> (Resource.Id.bgView);
				dot.SetImageResource(Resource.Drawable.positionCursor);
=======
				ImageView dot = FindViewById<ImageView> (Resource.Id.dotID);
				dot.SetImageResource (Resource.Drawable.positionCursor);
				dot.Right = 20;
				dot.Top = 20;
>>>>>>> ff5956e66caeda86e5b7e657aacc4e1e31a1201d
			};
		}
	}
}




