using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    /// <summary>
    /// own wrapper on array
    /// </summary>
    class BarldList<T> : IEnumerable<T>
    {
        private T[] _collection;

        public IEnumerator<T> GetEnumerator()
        {
            return this._collection.GetEnumerator() as IEnumerator<T>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._collection.GetEnumerator();
        }
    }
}
