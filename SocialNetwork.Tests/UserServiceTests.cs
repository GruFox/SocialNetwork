using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests;

[TestFixture]
public class UserServiceTests
{   
    [Test]
    public void AddFriend_MustThrowUserNotFoundException()
    {
        UserService userService = new UserService();

        UserAddingFriendData userAddingFriendData = new UserAddingFriendData() { FriendEmail = "gmail@gmail.com" };                

        Assert.Throws<UserNotFoundException>(() => userService.AddFriend(userAddingFriendData));
    }
}