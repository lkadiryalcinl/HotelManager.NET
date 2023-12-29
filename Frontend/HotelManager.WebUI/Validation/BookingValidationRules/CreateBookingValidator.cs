using FluentValidation;
using HotelManager.WebUI.Dtos.BookingDto;

namespace HotelManager.WebUI.Validation.BookingValidationRules
{
    public class CreateBookingValidator : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Name).MaximumLength(16).WithMessage("İsim alanı 3 karakterden az olamaz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı 20 karakterden fazla olamaz.");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail alanına uygun formatta değil.");

            RuleFor(x => x.CheckIn)
                .NotEmpty().WithMessage("Giriş tarihi boş olamaz.");
            RuleFor(x => x.CheckOut)
                .NotEmpty().WithMessage("Çıkış tarihi boş olamaz.");
            RuleFor(x => x)
                .Must(x => x.CheckOut == default(DateTime) || x.CheckIn == default(DateTime) || x.CheckOut > x.CheckIn)
                .WithMessage("Çıkış tarihi giriş tarihinden sonra olmalı.");

            RuleFor(x => x.SpecialRequest).Null();
        }
    }
}
