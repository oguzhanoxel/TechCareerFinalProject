using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        private IUserRepository _userRepository;
        public UserValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(u => u.Username)
                .MinimumLength(8).MaximumLength(16)
                .Must(NotUsernameExist).WithMessage("Username Already Exists.");

            RuleFor(u => u.Email).NotEmpty().EmailAddress()
                .Must(NotEmailExist).WithMessage("Email Already Exists.");

            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.City).NotEmpty();
            RuleFor(u => u.Address).NotEmpty();
            RuleFor(u => u.Birthdate).NotEmpty();
            RuleFor(u => u.Phone).NotEmpty();
        }

        private bool NotUsernameExist(string username)
        {
            if (_userRepository.GetAll().Any(u => u.Username == username))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool NotEmailExist(string email)
        {
            if (_userRepository.GetAll().Any(u => u.Email == email))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}