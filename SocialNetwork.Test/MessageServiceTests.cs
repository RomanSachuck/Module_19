using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTest
    {
        [Test]
        public void GetIncomingMessagesByUserIdTest()
        {
            MessageService messageService = new MessageService();
            Assert.IsEmpty(messageService.GetOutcomingMessagesByUserId(555));
        }
    }
}