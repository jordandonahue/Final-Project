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

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            int count = 0;



            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //get the button
            Button button = FindViewById<Button>(Resource.Id.testButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            //changes
        }
    }
}

