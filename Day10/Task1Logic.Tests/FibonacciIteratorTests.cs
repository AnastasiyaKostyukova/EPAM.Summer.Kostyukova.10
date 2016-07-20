using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic.Tests
{
    internal class FibonacciIteratorTests
    {
        [TestCase((uint)0, new long[] { })]
        [TestCase((uint)1, new long[] { 1 })]
        [TestCase((uint)2, new long[] { 1 , 1})]
        [TestCase((uint)5, new long[] { 1, 1, 2, 3, 5 })]
        [TestCase((uint)9, new long[] { 1, 1, 2, 3, 5, 8, 13, 21 })]
        [TestCase((uint)19, new long[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181})]
        public void FibonacciSequenceTest(uint count, IEnumerable<long> expectedSequence)
        {
            var testEnumerator = FibonacciIterator.GetSequenceFibonacci(count).GetEnumerator();
            var expectedEnumerator = expectedSequence.GetEnumerator();

            while (testEnumerator.MoveNext() && expectedEnumerator.MoveNext())
            {
                Assert.AreEqual(testEnumerator.Current, expectedEnumerator.Current);
            }
        }

        [TestCase((uint)91, 91)]
        [TestCase((uint)111, 92)]
        [TestCase((uint)93, 92)]
        public void FibonacciSequence_SequenceLenght(uint count, int expectedSequenceCount)
        {
            var sequenceCount = FibonacciIterator.GetSequenceFibonacci(count).Count();

            Assert.AreEqual(expectedSequenceCount, sequenceCount);
        }
    }
}
