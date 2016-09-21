namespace System.Linq
{
    public static class EnumerableExensions
    {
        /// <summary>
        /// Determines whether a sequence contains any elements.
        /// </summary>
        /// <returns>true if the source sequence contains any elements; otherwise, false.</returns>
        static public bool HasElement<T>(this Collections.Generic.IEnumerable<T> enumeralbe)
        {
            if (enumeralbe == null || !enumeralbe.Any())
            {
                return false;
            }
            
            return true;
        }
    }
}

