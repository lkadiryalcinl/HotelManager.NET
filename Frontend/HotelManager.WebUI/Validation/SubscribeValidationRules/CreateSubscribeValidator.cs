using FluentValidation;
using HotelManager.WebUI.Dtos.SubscribeDto;

namespace HotelManager.WebUI.Validation.SubscribeValidationRules
{
    public class CreateSubscribeValidator : AbstractValidator<CreateSubscribeDto>
    {
        public CreateSubscribeValidator() 
        {
            RuleFor(x => x.Mail).NotNull().NotEmpty().WithMessage("Mail alanı boş olamaz.");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail alanına uygun formatta değil.");
        }
    }
}
