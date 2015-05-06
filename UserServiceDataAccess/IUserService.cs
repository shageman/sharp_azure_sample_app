using System.Collections.Generic;
using UserService.Models;

namespace UserService
{
    public interface IUserService
    {
        List<User> GetUsers();

        void CreateUser(User user);
    }
}