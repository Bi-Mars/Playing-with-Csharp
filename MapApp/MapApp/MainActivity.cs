using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Google.Places;
using System.Collections.Generic;
using Android.Content;

namespace MapApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        //define references to all the components defined in activity_main.xml
        Button btnDisplay;
        TextView addressText, nameText, cordinateText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //create an instance
            btnDisplay = (Button)FindViewById(Resource.Id.btnDisplay);
            addressText = (TextView)FindViewById(Resource.Id.addressTxt);
            nameText = (TextView)FindViewById(Resource.Id.nameTxt);
            cordinateText = (TextView)FindViewById(Resource.Id.cordinateTxt);

            //event handler
            btnDisplay.Click += BtnDisplay_Click;
            
            if(!PlacesApi.IsInitialized) // if places api has not been initialized
            {
                PlacesApi.Initialize(this, "AIzaSyAggVxqc6dV5VH6TCpZfzaTDTCXeUxbwTI");
            }

        }

        private void BtnDisplay_Click(object sender, System.EventArgs e)
        {
            List<Place.Field> fields = new List<Place.Field>();
            fields.Add(Place.Field.Id);
            fields.Add(Place.Field.Name);
            fields.Add(Place.Field.LatLng);
            fields.Add(Place.Field.Address);

            Intent intent = new Autocomplete.IntentBuilder(AutocompleteActivityMode.Overlay, fields)
                .SetCountry("US")
                .Build(this);

            StartActivityForResult(intent, 0);

        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            var place = Autocomplete.GetPlaceFromIntent(data);
            addressText.Text = place.Address;
            nameText.Text = place.Name;
            
            cordinateText.Text = "Latitude " + place.LatLng.Latitude.ToString() + ", Longitude" + place.LatLng.Longitude.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}