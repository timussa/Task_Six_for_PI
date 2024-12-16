using Microsoft.VisualStudio.TestPlatform.TestHost;
using SomeoneProject;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(SomeoneProject.Program.DoubleNum(2), 4);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(SomeoneProject.Program.DoubleNum(4), 8);
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(SomeoneProject.Program.DoubleNum(-2), -4);
        }
    }
}