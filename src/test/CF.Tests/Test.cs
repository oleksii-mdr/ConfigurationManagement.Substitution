using System.Configuration;
using NUnit.Framework;

namespace CF.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestFoo()
        {
            string configName = ConfigurationManager.AppSettings["configName"];
            Assert.IsNotNullOrEmpty(configName);
        }
    }
}
