using BinarySearch;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ArrayOfIntTest()
        {
            int[] array = { 1, 4, 6, 7, 8, 9, 12 };
            int expected = 3;
            int actual = array.Search(7, (a, b) => a.CompareTo(b));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayOfStringTest()
        {
            string[] array = { "cat", "dog", "hawk", "jaguar" };
            int expected = 2;
            int actual = array.Search("hawk", (a, b) => a.CompareTo(b));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayOfCharTest()
        {
            char[] array = { 'a', 'b', 'c', 'd' };
            int expected = 1;
            int actual = array.Search('b', (a, b) => a.CompareTo(b));

            Assert.AreEqual(expected, actual);
        }
    }
}