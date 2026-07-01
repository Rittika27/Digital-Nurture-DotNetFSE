using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        Mock<IMailSender> mockMailSender;
        CustomerCommLib.CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            customerComm = new CustomerCommLib.CustomerComm(mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomerTest()
        {
            bool result = customerComm.SendMailToCustomer();
            Assert.That(result, Is.EqualTo(true));
        }
    }
}
