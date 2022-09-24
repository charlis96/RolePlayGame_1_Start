using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void ValidName()
        {
            string expectedname = "Harry";
            Wizard Harry = new Wizard("Harry");
            Assert.AreEqual(expectedname, Harry.Name);
        }
    }
}