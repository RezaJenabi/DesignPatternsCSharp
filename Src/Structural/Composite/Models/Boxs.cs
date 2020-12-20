using System.Collections.Generic;

namespace Composite.Models
{
    public class Boxs : Component, IComposite
    {
        protected List<Component> _children = new List<Component>();

        public void Add(Component component)
        {
            _children.Add(component);
        }

        public void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Box[ ";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                {
                    result += " + ";
                }
                i++;
            }

            return result + " ]";
        }
    }
}