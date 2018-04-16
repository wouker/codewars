using NUnit.Framework;
using TheCode;

namespace UnitTestProject
{
    [TestFixture]
    public class OddSortTests
    {
        [Test]
        public void OddSort_Basic1()
        {
            Assert.AreEqual(new int[] {1, 3, 2, 8, 5, 4}, OddSort.SortArray(new int[] {5, 3, 2, 8, 1, 4}));
        }

        [Test]
        public void OddSort_Basic2()
        {
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, OddSort.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }

        [Test]
        public void OddSort_Empty()
        {
            Assert.AreEqual(new int[] { }, OddSort.SortArray(new int[] { }));
        }

        [Test]
        public void OddSort_RecurringEvens_ShouldStay()
        {
            Assert.AreEqual(new int[] { 37, 84, 41, 49, 51, 57, 34, 57, 59, 6, 38, 78, 75, 77, 84, 18, 85, 87, 84, 99, 50 }, 
                OddSort.SortArray(new int[] { 41, 84, 77, 49, 37, 57, 34, 57, 59, 6, 38, 78, 75, 51, 84, 18, 85, 87, 84, 99, 50 }));
            
        }
    }
}
