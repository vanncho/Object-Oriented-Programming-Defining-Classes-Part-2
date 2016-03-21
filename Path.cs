namespace Homework
{
    using System.Collections.Generic;

    public class Path 
    {
        private List<Point3D> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints
        {
            get { return this.sequenceOfPoints; }
            set { this.sequenceOfPoints = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.SequenceOfPoints.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.SequenceOfPoints.Remove(point);
        }
    }
}
