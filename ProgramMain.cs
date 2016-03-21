namespace Homework
{
    using System;
    using System.Collections.Generic;

    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            //var firstCoordinates = new Point3D(5.5, 4.2, 3.3);
            //
            //Console.WriteLine(firstCoordinates.ToString());
            //Console.WriteLine(firstCoordinates.StartPointZero());
            //
            //var secondCoordinates = new Point3D(2.3, 2.2, 2.1);
            //
            //double distance = GetDistance.CalculateDistance(firstCoordinates, secondCoordinates);
            //
            //Console.WriteLine(distance);
            //
            //var path = new Path();
            //
            //path.AddPoint(firstCoordinates);
            //
            //PathStorage.SavePath(path, "points");
            //
            //Path loadedPath = PathStorage.LoadPath(@"..//..//points.txt");
            //
            //for (int i = 0; i < loadedPath.SequenceOfPoints.Count; i++)
            //{
            //    Console.WriteLine(loadedPath.SequenceOfPoints[i]);
            //}

            var myList = new GenericList<int>(4);

            myList.AddElement(1);
            myList.AddElement(2);
            myList.AddElement(3);
            myList.AddElement(4);
            myList.AddElement(5);
            myList.AddElement(6);
            myList.AddElement(7);
            myList.AddElement(8);

            myList.InsertAtIndex(2, 10);

            ////myList.FindElement(4);
            //
            //Console.WriteLine(myList.FindElement(10));
            //
            //var myStringList = new GenericList<string>(4);
            //
            //myStringList.AddElement("Maria");
            //myStringList.AddElement("Ivan");
            //
            //int index = myStringList.FindElement("Gosho");
            //
            //Console.WriteLine(myList.ToString());
            //Console.WriteLine(myStringList.ToString());
            //
            //Console.WriteLine(index);

            Console.WriteLine(myList.Min());
            Console.WriteLine(myList.Max());

            var nnn = new Matrix<int>(5, 5);
            var mmm = new Matrix<int>(5, 5);

            var vcc = nnn + mmm;
        }
    }
}
