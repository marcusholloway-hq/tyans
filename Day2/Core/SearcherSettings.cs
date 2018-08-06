using System;
using System.Collections.ObjectModel;

namespace Day2.Core
{
    /// <summary>
    /// Settings for searcher
    /// </summary>
    public class SearcherSettings<T> where T : class
    {
        // ReadOnlyCollection of instances to search in
        public ReadOnlyCollection<T> _objects;

        /// <summary>
        /// Basic settings for searcher
        /// </summary>
        public SearcherSettings(ReadOnlyCollection<T> objects)
        {
            if (objects == null)
                throw new ArgumentNullException(nameof(objects));
            if (objects.Count == 0)
                throw new ArgumentOutOfRangeException(nameof(objects));

            _objects = objects;
        }
    }
}
