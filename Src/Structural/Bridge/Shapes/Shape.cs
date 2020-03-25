using Bridge.Colors;

namespace Bridge.Shapes
{
    public class Shape
    {
        protected IColor _color;

        public Shape(IColor color)
        {
            _color = color;
        }

        public virtual string Operation()
        {
            return "Shape: Base operation with:\n" +
                _color.OperationColor();
        }
    }
}