using Bridge.Colors;

namespace Bridge.Shapes
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override string Operation()
        {
            return "Square: Extended operation with:\n" +
                _color.OperationColor();
        }
    }
}