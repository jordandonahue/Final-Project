﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace App9
{
    [Activity(Label = "App9", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var continueButton = FindViewById<Button>(Resource.Id.btnContinue);
            continueButton.Click += delegate
            {
                SetContentView(Resource.Layout.Second);

            };
                      

        }
    }
    
}



