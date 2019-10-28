namespace MapsTest
{
    class StopsLocations
    {
        private string name;
        private double x;
        private double y;

        public StopsLocations(string Name, double X, double Y)
        {
            name = Name;
            x = X;
            y = Y;
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