namespace ShapeWorld.Domain.Models
{

  public class Square : Rectangle
  {
    private double _edgeLength;
    public override double Length()
    {
      private double _edgeLength
      get
      {
        return Length;
      }
      set
      {
        _edgeLength = value;
      }
      
      public override double Width
      {
        get
        {
          return _edgeLength;
        }
        set
        {
          _edgeLength = Length;
        }
        public override double Perimeter()
        {
          return 4 * Length;
        }

        public Square()
        {
          Length = Width;
        }
        //public int NumberofEdges { get;}
        /* public Square() : base(4)
        {
          //NumberofEdges = 4;
        } */
      }
    }
  

  }
}