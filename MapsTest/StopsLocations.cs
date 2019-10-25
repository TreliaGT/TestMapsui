using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MapsTest
{
    class StopsLocations {

        private string name;


        private double x;
        private double y;


        public StopsLocations(string Name, double x, double y)
        {

            this.name = Name;

            this.x = x;
            this.y = y;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}