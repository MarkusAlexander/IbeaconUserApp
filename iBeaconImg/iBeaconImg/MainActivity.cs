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
			var imageView = FindViewById<ImageView> (Resource.Id.demoImageView);
			ImageView dot = (ImageView) FindViewById(Resource.Drawable.positionCursor);

			var b1 = new iBeacon();
			var b2 = new iBeacon();
			var b3 = new iBeacon();

			b1.X = 200;
			b1.Y = 100;
			b2.X = 290;
			b2.Y = 520;
			b3.X = 20;
			b3.Y = 1000;

			var dotpos = tr.Trilaterate (b1, b2, b3);

			//Din mamma <3

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




