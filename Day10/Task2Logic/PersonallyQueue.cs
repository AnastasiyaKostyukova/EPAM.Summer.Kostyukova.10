using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public class PersonallyQueue<T> : IEnumerable<T>
    {
        private T[] queueElements = new T[0];

        public int Count()
        {
            return queueElements.Length;
        }

        public void Enqueue(T element)
        {
            queueElements = CopyInIncreaseArray(queueElements);
            queueElements[queueElements.Length - 1] = element;
        }

        public T Dequeue()
        {
            CheckQueueLenght();
            T ob = queueElements[0];
            queueElements = CopyInReduceArray(queueElements);
            return ob;
        }

        public T Peek()
        {
            CheckQueueLenght();
            return queueElements[0];
        }

        public void Clear()
        {
            queueElements = new T[0];
        }

        public bool Contains(T checkedQueueElement)
        {
            return queueElements.Contains(checkedQueueElement);
        }

        private T[] CopyInReduceArray(T[] arr)
        {
            T[] copiedArray = new T[arr.Length - 1];
            Array.Copy(arr, 1, copiedArray, 0, arr.Length - 1);
            return copiedArray;
        }

        private T[] CopyInIncreaseArray(T[] arr)
        {
            T[] copiedArray = new T[arr.Length + 1];
            Array.Copy(arr, 0, copiedArray, 0, arr.Length);
            return copiedArray;
        }

        private void CheckQueueLenght()
        {
            if (queueElements.Length == 0)
            {
                throw new Exception("Empty queue");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueEnum<T> qEnum = new QueueEnum<T>(queueElements);
            return qEnum;
        }

         public System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (System.Collections.IEnumerator)GetEnumerator();
        }





        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
