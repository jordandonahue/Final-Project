using Android.App;
using Android.Widget;
using Android.OS;
using System;

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

            Spinner yearSpinner = FindViewById<Spinner>(Resource.Id.Year);
            yearSpinner.Prompt = "Choose your Year";
            yearSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(yearSpinner_ItemSelected);
           // var adapter = ArrayAdapter.CreateFromResource(this, Resource.String.year_array, Resource.Layout.Main);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);

            var continueButton = FindViewById<Button>(Resource.Id.btnContinue);
            continueButton.Click += delegate
            {
                StartActivity(typeof(vehicleInfoActivity));

            };
                      
        }
        private void yearSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner yearSpinner = (Spinner)sender;

            string toast = string.Format("Selected Year: ", yearSpinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();

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



