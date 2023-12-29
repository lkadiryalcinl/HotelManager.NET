using FluentValidation;
using FluentValidation.AspNetCore;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.EntityLayer.Concrete;
using HotelManager.WebUI.Dtos.BookingDto;
using HotelManager.WebUI.Dtos.ContactDto;
using HotelManager.WebUI.Dtos.LoginDto;
using HotelManager.WebUI.Dtos.RegisterDto;
using HotelManager.WebUI.Dtos.SubscribeDto;
using HotelManager.WebUI.Validation.BookingValidationRules;
using HotelManager.WebUI.Validation.ContactValidationRules;
using HotelManager.WebUI.Validation.LoginValidationRules;
using HotelManager.WebUI.Validation.RegisterValidationRules;
using HotelManager.WebUI.Validation.SubscribeValidationRules;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IValidator<CreateSubscribeDto>, CreateSubscribeValidator>();
builder.Services.AddTransient<IValidator<CreateBookingDto>, CreateBookingValidator>();
builder.Services.AddTransient<IValidator<CreateContactDto>, CreateContactValidator>();
builder.Services.AddTransient<IValidator<CreateNewUserDto>, RegisterValidator>();
builder.Services.AddTransient<IValidator<LoginUserDto>, LoginValidator>();

builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
