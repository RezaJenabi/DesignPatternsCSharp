using System;

namespace Composite.Models
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