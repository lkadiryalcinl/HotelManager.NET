using FluentValidation;
using HotelManager.WebUI.Dtos.RegisterDto;

namespace HotelManager.WebUI.Validation.RegisterValidationRules
{
    public class RegisterValidator : AbstractValidator<CreateNewUserDto>
    {
        public RegisterValidator() 
        {
            RuleFor(x => x.Username).NotEmpty().NotNull().WithMessage("Kullanıcı adı alanı boş olamaz.");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı adı alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Şifre alanı boş olamaz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Kullanıcı adı alanı 8 karakterden az olamaz.");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Kullanıcı adı alanı 20 karakterden fazla olamaz.");
            RuleFor(x => x.Password).Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,20}$")
            .WithMessage("Şifre en az bir küçük harf, bir büyük harf ve bir rakam içermelidir; toplam uzunluğu 8 ile 20 karakter arasında olmalıdır."); ;

            RuleFor(x => x.ConfirmPassword).NotEmpty().NotNull().WithMessage("Şifre onayla alanı boş olamaz.");
            RuleFor(x => x.ConfirmPassword)
            .Equal(x => x.Password)
            .WithMessage("Şifre ve Şifre onayla alanları eşleşmelidir.");

            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Name).MaximumLength(16).WithMessage("İsim alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez.");
            RuleFor(x => x.Surname).MaximumLength(16).WithMessage("İsim alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("İsim alanı 20 karakterden fazla olamaz.");

            
        }
    }
}
