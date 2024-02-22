using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    internal class AddingAsFriendView
    {
        public void Show(User user)
        {
            UserService userService = new UserService();
            var addingAsFriendData = new UserAddingAsFriendData();

            Console.WriteLine("Введите почтовый адрес пользователя для добавления в друзья:");
            addingAsFriendData.FriendEmail = Console.ReadLine();

            addingAsFriendData.UserId = user.Id;

            try
            {
                userService.AddFriend(addingAsFriendData);
                SuccessMessage.Show("Теперь у вас на одного друга больше!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
        }
    }
}
