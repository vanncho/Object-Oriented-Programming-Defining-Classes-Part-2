namespace Homework
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string nameOfFileToSave)
        {
            using (StreamWriter sw = new StreamWriter("..//..//" + nameOfFileToSave + ".txt"))
            {
                for (int i = 0; i < path.SequenceOfPoints.Count; i++)
                {
                    sw.WriteLine(path.SequenceOfPoints[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string currentLine = sr.ReadLine();
                Point3D point = Point3D.Parse(currentLine);
                path.AddPoint(point);
            }

            return path;
        }
    }
}