using FluentValidation;
using HotelManager.WebUI.Dtos.LoginDto;

namespace HotelManager.WebUI.Validation.LoginValidationRules
{
    public class LoginValidator : AbstractValidator<LoginUserDto>
    {
        public LoginValidator() 
        {
            RuleFor(x => x.Username).NotEmpty().NotNull().WithMessage("Kullanıcı adı alanı boş olamaz.");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı adı alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Şifre alanı boş olamaz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Kullanıcı adı alanı 8 karakterden az olamaz.");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Kullanıcı adı alanı 20 karakterden fazla olamaz.");
        }
    }
}
