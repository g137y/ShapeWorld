namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
      //fields
      //private int numberOfEdges; //backing field

      //properties (field with working of method)
      public int NumberOfEdges { get; }
      //Short term for getter and setter
       */{
         get
         {
           return numberOfEdges;
         }
         set 
         {
           numberOfEdges = value;
         }
       }*/
       // methods

       public virtual double Perimeter()
       {
         return 0;
       }

       public abstract double Surface(); //Abstract

       public double Volume()
       {
         return 0;
       }
       //controllers
       public Shape (int edges)
       {
         NumberOfEdges = edges;
       }
    }
}




