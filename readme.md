milestone 1 = plan of attack

milestone 2 = create app layout and design basics. Add a list and details view. start adding spinners and other basic 
user interface items. start figuring out what vehicle makes/models i will support and how much information i will provide
per vehicle. 

milestone 3 = start getting most ui items in place. include orientation awareness and have subtle differences in the 
design/layout of the app between orientations. incorporate support on multiple devices(tablet,phone). have details and info
ready to be inserted into the ui for next milestone. 

milestone 4 = have all vehicle in database format ready to be integrated and accessed by the application. have final
touches finished up on the ui and all improvements made. have all ui components tested and fully functional. make
sure all comments are in proper places, intact and are meaningful. test activities, test on both device formats
and on both orientation formats on said devices. ensure all code is together and working. 


scrapped code{


            //yearSpinner
            var yearSpinner = FindViewById<Spinner>(Resource.Id.Year);
            yearSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(yearSpinner_ItemSelected);
            var yearAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.year_array, Android.Resource.Layout.SimpleSpinnerItem);
            yearAdapter.NotifyDataSetChanged();
            yearAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            yearSpinner.Adapter = yearAdapter;


            //makeSpinner
            var makeSpinner = FindViewById<Spinner>(Resource.Id.Make);
            makeSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(makeSpinner_ItemSelected);
            var makeAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.make_array, Android.Resource.Layout.SimpleSpinnerItem);
            makeAdapter.NotifyDataSetChanged();
            makeAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            makeSpinner.Adapter = makeAdapter;
            

            //continueButton 
            var continueButton = FindViewById<Button>(Resource.Id.btnContinue);
                continueButton.Click += continueButton_click;

            }
        private void continueButton_click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(vehicleInfoActivity));
        }

        private void yearSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        public void makeSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this,"" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
            string str = spinner.GetItemAtPosition(e.Position).ToString();
            if (spinner.Activated)
            {
                
            }
            switch (str)
            {
                case "Honda":
                    //HondaModelSpinner
                    var hondaSpinner = FindViewById<Spinner>(Resource.Id.Model);
                    hondaSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(hondaSpinner_ItemSelected);
                    var hondaAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.honda_array, Android.Resource.Layout.SimpleSpinnerItem);
                    hondaAdapter.NotifyDataSetChanged();
                    hondaAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                    hondaSpinner.Adapter = hondaAdapter;
                    string str1 = hondaSpinner.GetItemAtPosition(e.Position).ToString();
                    
                    switch (str1)
                    {
                        case "Civic":
                            //honda civic engine spinner
                            var civicEngineSpinner = FindViewById<Spinner>(Resource.Id.Engine);
                            civicEngineSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(civicEngineSpinner_ItemSelected);
                            var civicEngineAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.civicEngine_array, Android.Resource.Layout.SimpleSpinnerItem);
                            civicEngineAdapter.NotifyDataSetChanged();
                            civicEngineAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                            civicEngineSpinner.Adapter = civicEngineAdapter;
                            break;

                        case "Accord":
                            var accordEngineSpinner = FindViewById<Spinner>(Resource.Id.Engine);
                            accordEngineSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(accordEngineSpinner_ItemSelected);
                            var accordEngineAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.accordEngine_array, Android.Resource.Layout.SimpleSpinnerItem);
                            accordEngineAdapter.NotifyDataSetChanged();
                            accordEngineAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                            accordEngineSpinner.Adapter = accordEngineAdapter;
                            break;
                    }

                    break;
                case "Toyota":
                    //ToyotaModelSpinner
                    var toySpinner = FindViewById<Spinner>(Resource.Id.Model);
                    toySpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(toySpinner_ItemSelected);
                    var toyAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.toyota_array, Android.Resource.Layout.SimpleSpinnerItem);
                    toyAdapter.NotifyDataSetChanged();
                    toyAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                    toySpinner.Adapter = toyAdapter;

                    string str2 = toySpinner.GetItemAtPosition(e.Position).ToString();


                    switch (str2)
                    {
                        case "Corolla":
                            //honda civic engine spinner
                            var corollaEngineSpinner = FindViewById<Spinner>(Resource.Id.Engine);
                            corollaEngineSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(corollaEngineSpinner_ItemSelected);
                            var corollaEngineAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.corollaEngine_array, Android.Resource.Layout.SimpleSpinnerItem);
                            corollaEngineAdapter.NotifyDataSetChanged();
                            corollaEngineAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                            corollaEngineSpinner.Adapter = corollaEngineAdapter;
                            break;

                        case "Camry":
                            var camryEngineSpinner = FindViewById<Spinner>(Resource.Id.Engine);
                            camryEngineSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(camryEngineSpinner_ItemSelected);
                            var camryEngineAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.camryEngine_array, Android.Resource.Layout.SimpleSpinnerItem);
                            camryEngineAdapter.NotifyDataSetChanged();
                            camryEngineAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                            camryEngineSpinner.Adapter = camryEngineAdapter;
                            break;
                    }

                    break;
            }
        }
        private void toySpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        private void hondaSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        private void civicEngineSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        private void accordEngineSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        private void corollaEngineSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
        }
        private void camryEngineSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "" + spinner.GetItemAtPosition(e.Position), ToastLength.Short);
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

   
   






}