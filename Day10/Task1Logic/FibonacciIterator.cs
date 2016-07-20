using System;
using System.Collections.Generic;

namespace Task1Logic
{
    public class FibonacciIterator
    {
        public static IEnumerable<long> GetSequenceFibonacci (uint count)
        {
            long previousElementSequence = 1;
            long currentElementSequence = 0;
            long nextElementSequence = 0;

            for (int i = 0; i < count; i++)
            {
                if (long.MaxValue - currentElementSequence < previousElementSequence)
                {
                    yield break;
                }
                nextElementSequence = previousElementSequence + currentElementSequence;
                previousElementSequence = currentElementSequence;
                currentElementSequence = nextElementSequence;

                yield return currentElementSequence;
            }
        }
    }
}
