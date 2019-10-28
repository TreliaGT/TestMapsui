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

      /*  private static void LoadPoints()
        {
            MapControl mapControl = null;// Get MapControl element here.
            var map = new Map();

            map.Layers.Add(OpenStreetMap.CreateTileLayer());
            map.Layers.Add(new MemoryLayer
            {
                Style = null,
                // Get all the stops as features and set it as the data source.
                DataSource = new MemoryProvider(GetStops())
            });
        }
​
        private static Features GetStops()
        {
            // Prepare a features variable, and build the data to populate it.
            var features = new Features();
            List<StopsLocations> list = new List<StopsLocations>();
            list.Add(new StopsLocations("someday", 115.85713, -31.95496));
            list.Add(new StopsLocations("something", 115.859821, -31.958627));
​
    // Add each stop as a feature to features.
                foreach (var stop in list)
                {
                // Get the coordinates for each stop.
                var coordinates = SphericalMercator.FromLonLat(stop.X, stop.Y);
                List<Style> styles = new List<Style>();
​
        // Styles are usefull for adding a group of elements to the map, you can add more than a label if you like.
        styles.Add(new LabelStyle { Text = stop.Name });
​
        // Add the new Feature to Features.
        features.Add(new Feature
        {
            Geometry = coordinates,
            ["Label"] = stop.Name,
            Styles = styles.ToArray()
            });
             }
​
            // Return the features.
            return features;
        }*/
    }
}