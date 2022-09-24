using NUnit.Framework;
using Program;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void ValidName()
        {
            string expectedname = "Harry";
            Wizzard Harry = new Wizzard ("Harry");
            Assert.AreEqual(expectedname,Harry.Name);
        }
    }
}