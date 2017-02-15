using Android.App;
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
            SetContentView(Resource.Layout.Main);
            // Set our view from the "main" layout resource

            var continueButton = FindViewById<Button>(Resource.Id.btnContinue);
            continueButton.Click += delegate
            {
                StartActivity(typeof(vehicleInfoActivity));

            };
                      
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



