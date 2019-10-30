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
using Mapsui.Providers;
using Mapsui.Styles;
using System.Collections.Generic;
using Mapsui.Layers;
using Mapsui.UI;

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

            map.Info += DoStuff_OnInfo;
        }

        

        public void DoStuff_OnInfo(object sender, MapInfoEventArgs e)
        {
          //  e.MapInfo.Feature.
        }
    }
}