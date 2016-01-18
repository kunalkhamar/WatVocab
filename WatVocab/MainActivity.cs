using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace WatVocab
{
	[Activity (Label = "WatVocab", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button buttonLogin = FindViewById<Button> (Resource.Id.buttonLogin);
			
			buttonLogin.Click += (object sender, EventArgs e) => {
				StartActivity(typeof(VocabListActivity));
			};
		}
	}
}


