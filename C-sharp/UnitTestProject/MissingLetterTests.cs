using NUnit.Framework;
using TheCode;

namespace UnitTestProject
{
    [TestFixture]
    public class MissingLetterTests
    {
        [Test]
        public void MissingLetterTests_TestLower()
        {
            Assert.AreEqual('e', MissingLetterFinder.Find(new[] { 'a', 'b', 'c', 'd', 'f' }));
        }

        [Test]
        public void MissingLetterTests_TestUpper()
        {
            Assert.AreEqual('P', MissingLetterFinder.Find(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}
