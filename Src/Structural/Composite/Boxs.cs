﻿using System.Collections.Generic;

namespace Composite
{
    public class Boxs : Component, IComposite
    {
        protected List<Component> _children = new List<Component>();

        public void Add(Component component)
        {
            this._children.Add(component);
        }

        public void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Box[ ";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += " + ";
                }
                i++;
            }

            return result + " ]";
        }
    }
}