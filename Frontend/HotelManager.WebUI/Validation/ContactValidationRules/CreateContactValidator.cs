using FluentValidation;
using HotelManager.WebUI.Dtos.ContactDto;

namespace HotelManager.WebUI.Validation.ContactValidationRules
{
    public class CreateContactValidator : AbstractValidator<CreateContactDto>
    {
        public CreateContactValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Name).MaximumLength(16).WithMessage("İsim alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail alanına uygun formatta değil.");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş olamaz.");
            RuleFor(x => x.Subject).MaximumLength(16).WithMessage("Konu alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş olamaz.");
            RuleFor(x => x.Message).MinimumLength(20).WithMessage("Mesaj alanı 20 karakterden az olamaz.");
            RuleFor(x => x.Message).MaximumLength(300).WithMessage("Mesaj alanı 200 karakterden fazla olamaz.");

        }
    }
}
