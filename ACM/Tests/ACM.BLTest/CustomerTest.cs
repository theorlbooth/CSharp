using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            {
                FirstName = "Bilbo";
                LastName = "Baggins";
            };
            string expected = "Baggins, Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
