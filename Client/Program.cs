using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    // if private is used, this means it is available to namespace. However, compiler needs to access Main().
    {
      //access regular return name parameters
        private static void Main(string[] args)
        {
            PlayWithShape();
        }
        private static void PlayWithShape()
        {
          Shape someShape = new Rectangle();
          Square someSquare = new Square();
          //Rectangle someRectangle = new Rectangle() as Square; //casting
          //Rectangle someRectangle2 = (Square) new Rectangle();

          someSquare.Length = 10;
          someSquare.Width = 100;

           //someShape.NumberOfEdges = 10;
           //someShape.NumberOfEdges; 
           //Console.Write(someShape.NumberOfEdges);
           Console.WriteLine(someSquare.NumberOfEdges);
        }
    }
}
