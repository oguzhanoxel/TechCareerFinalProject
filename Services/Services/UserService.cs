using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IDataResult<User> Login(string username, string password)
        {
            User user = _userRepository.Get(u => u.Username == username);

            if (user != null)
            {
                if (user.Password == password)
                {
                    if (user.Status == true)
                    {
                        // login success
                        return new SuccessDataResult<User>(user);
                    }
                    else
                    {
                        // 'password' is not 'user.password'
                        return new ErrorDataResult<User>("Account not active !!!");
                    }
                }
                else
                {
                    // 'password' is not 'user.password'
                    return new ErrorDataResult<User>("username or password wrong !!!");
                }
            }
            else
            {
                // 'user' objects is null
                return new ErrorDataResult<User>("username or password wrong !!!");
            }
        }

        public IResult Register(User user)
        {
            try
            {
                _userRepository.Add(user);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public List<User> Search(string search = "")
        {
            if (search.Length > 0)
            {
                return _userRepository.GetAll(u => u.Username.Contains(search) || u.Email.Contains(search) || u.FirstName.Contains(search) || u.LastName.Contains(search));
            }

            return _userRepository.GetAll();
        }

        public IResult PasswordReset(User user, string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                user.Password = password;
                _userRepository.Update(user); 
                return new SuccessResult("Password Changed.");
            } else
            {
                return new ErrorResult("Does not match password");
            }
        }

        public IResult Edit(User user)
        {
            _userRepository.Update(user);
            return new SuccessResult("Account Updated.");
        }

        public IResult Delete(User user)
        {
            _userRepository.Delete(user);
            return new SuccessResult("Account Deleted.");
        }
    }
}
