using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistation_Using_MsTest;

namespace UserRegistration_MsTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void TestFirstName()
        {
            bool result = pattern.ValidateFirstName("Pratik");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastName()
        {
            bool result1 = pattern.ValidateLastName("Ingole");
            Assert.IsTrue(result1);
        }
        [TestMethod]
        public void TestEmail()
        {
            bool result2 = pattern.ValidateEmail("pratik.ingole98@gmail.com");
            Assert.IsTrue(result2);
        }
        [TestMethod]
        public void TestMobileNumber()
        {
            bool result3 = pattern.ValidateMobileNumber("91 7709197897");
            Assert.IsTrue(result3);
        }
        [TestMethod]
        public void TestpasswordRule1()
        {
            bool result4 = pattern.validatePassword("Pass@123");
            Assert.IsTrue(result4);
        }
    }
}