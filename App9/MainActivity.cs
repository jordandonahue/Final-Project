using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace App9
{
    [Activity(Label = "Oil Change Info", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            // Set our view from the "main" layout resource

            //continueButton 
            var continueButton = FindViewById<Button>(Resource.Id.btnContinue);
            continueButton.Click += continueButton_click;

        }
        private void continueButton_click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(vehicleInfoActivity));
        }
        

            }
    public class vehicleInfoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Second);

            var backButton = FindViewById<Button>(Resource.Id.btnBack);
            backButton.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}


