using System;

namespace GenericOgren
{
    internal class MyList<T>
    {
        public static implicit operator MyList<T>(MyList v)
        {
            throw new NotImplementedException();
        }
    }
}