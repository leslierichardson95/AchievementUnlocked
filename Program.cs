using AchievementUnlocked.Models;
using AchievementUnlocked.Validation;
using FluentValidation;
using FluentValidation.Results;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<SignupRequest>, SignupValidator>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/api/signup", (SignupRequest request, IValidator<SignupRequest> validator) =>
{
    ValidationResult result = validator.Validate(request);

    if (!result.IsValid)
    {
        var errors = result.Errors
            .GroupBy(e => e.PropertyName)
            .ToDictionary(g => g.Key, g => g.Select(e => e.ErrorMessage).ToArray());

        return Results.BadRequest(new { ok = false, errors });
    }

    return Results.Ok(new
    {
        ok = true,
        achievement = new { icon = "🎉", name = "Welcome Aboard!" },
        message = $"Welcome, {request.DisplayName}! Your trophy case is saved."
    });
});

app.Run();
