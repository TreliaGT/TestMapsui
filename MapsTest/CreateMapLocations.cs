

using Android.Content;
using Android.Graphics.Drawables;
using Mapsui;
using Mapsui.Layers;
using Mapsui.Projection;
using Mapsui.Providers;
using Mapsui.Styles;
using Mapsui.Utilities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MapsTest
{
    class CreateMapLocations
    {
        private Context con;

        private Map map;

        public CreateMapLocations(Context context)
        {
            con = context;
        }


        public Mapsui.Map CreateMap()
        {
            map = new Map();
            map.Layers.Add(OpenStreetMap.CreateTileLayer());
            
            // Get the lon lat coordinates from somewhere (Mapsui can not help you there)
            var center = new Mapsui.Geometries.Point(115.85713, -31.95496);
            // OSM uses spherical mercator coordinates. So transform the lon lat coordinates to spherical mercator
            var sphericalMercatorCoordinate = SphericalMercator.FromLonLat(center.X, center.Y);
            // Set the center of the viewport to the coordinate. The UI will refresh automatically
           map.NavigateTo(sphericalMercatorCoordinate);
            // Additionally you might want to set the resolution, this could depend on your specific purpose
           map.NavigateTo(map.Resolutions[5]);

            CreatePointer();
            return map;
        }

      

     public void CreatePointer()
        {
            var bitmap = ((BitmapDrawable)con.Resources.GetDrawable(Resource.Drawable.info, con.Theme)).Bitmap;

            Stream stream = new MemoryStream();
            bitmap.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 0, stream);

            map.Layers.Add(new MemoryLayer
            {
              
                DataSource = new MemoryProvider(GetStops()),
                Style = new SymbolStyle
                {
                    BitmapId = BitmapRegistry.Instance.Register(stream),
                    SymbolOffset = new Offset(0f, 0f),
               
                    // SymbolScale will need to be adjusted.
                    SymbolScale = 0.3
                }
            });
        }


        private static IEnumerable<IFeature> GetStops()
        {
            List<StopsLocations> list = new List<StopsLocations>();
            list.Add(new StopsLocations("someday", 115.85713, -31.95496));
            list.Add(new StopsLocations("someday", 115.859821, -31.958627));
            var cities = list;

            return cities.Select(c =>
            {
                var feature = new Feature();
                var point = SphericalMercator.FromLonLat(c.X, c.Y);
                feature.Geometry = point;
                feature["name"] = c.Name;
               
                feature.Styles.Add(new LabelStyle { Text = c.Name });
                return feature;
            });
        }



    }
}