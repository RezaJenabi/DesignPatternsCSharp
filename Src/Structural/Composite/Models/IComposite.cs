﻿namespace Composite.Models
{
    public interface IComposite
    {
        void Add(Component component);

        void Remove(Component component);
    }
}