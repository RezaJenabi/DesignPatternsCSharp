using System;

namespace Composite
{
    public abstract class Component
    {

        public abstract string Operation();

       

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}