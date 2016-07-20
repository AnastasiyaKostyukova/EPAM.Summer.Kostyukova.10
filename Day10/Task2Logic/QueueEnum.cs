using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    class QueueEnum<T> : IEnumerator<T>
    {
        private T[] queueElements;
        private int position = -1;

        public QueueEnum(T[] queueEls)
        {
            queueElements = queueEls;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                return queueElements[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < queueElements.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }
    }
}
