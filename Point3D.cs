namespace Homework
{
    using System.Text.RegularExpressions;

    public struct Point3D
    {
        public static readonly int StartX = 0;
        public static readonly int StartY = 0;
        public static readonly int StartZ = 0;

        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public static Point3D Parse(string pointsInFile)
        {
            string pattern = "([0-9].?[0-9]?)";
            MatchCollection matches = Regex.Matches(pointsInFile, pattern);

            return new Point3D(double.Parse(matches[0].ToString()), double.Parse(matches[1].ToString()), double.Parse(matches[2].ToString()));
        }

        public Point3D StartPointZero()
        {
            return new Point3D(StartX, StartY, StartZ);
        }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Z = {1}", this.x, this.y, this.z);
        }
    }
}
