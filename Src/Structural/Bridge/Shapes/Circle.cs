using Bridge.Colors;

namespace Bridge.Shapes
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override string Operation()
        {
            return "Circle: Extended operation with:\n" +
                _color.OperationColor();
        }
    }
}