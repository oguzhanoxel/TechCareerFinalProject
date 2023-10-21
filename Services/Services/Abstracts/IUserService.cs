using DataAccess.Entities;
using Services.Results;
using System.Collections.Generic;

namespace Services.Services.Abstracts
{
    public interface IUserService
    {
        IDataResult<User> Login(string username, string password);
        IResult Register(User user);
        List<User> Search(string search = "");
        IResult PasswordReset(User user, string password, string confirmPassword);
        IResult Edit(User user);
        IResult Delete(User user);
    }
}
