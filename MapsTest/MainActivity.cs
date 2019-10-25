using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Mapsui.Utilities;
using Mapsui;
using Mapsui.UI.Android;
using Android.Graphics.Drawables;
using Mapsui.Projection;

namespace MapsTest
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var mapControl = FindViewById<MapControl>(Resource.Id.mapcontrol);

            var map = new Mapsui.Map();
            
            mapControl.Map = new CreateMapLocations(this).CreateMap();
            //mapControl.Map = map;
       

        }
    }
}