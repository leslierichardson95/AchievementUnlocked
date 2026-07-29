using AchievementUnlocked.Models;
using FluentValidation;

namespace AchievementUnlocked.Validation;

public class SignupValidator : AbstractValidator<SignupRequest>
{
    public SignupValidator()
    {
        RuleFor(x => x.DisplayName)
            .NotEmpty().WithMessage("Please choose a display name.")
            .MaximumLength(30).WithMessage("Display name must be 30 characters or fewer.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Please enter your email.")
            .EmailAddress().WithMessage("That doesn't look like a valid email.");

        // Password must be strong enough to protect a player's saved trophies:
        // at least 8 characters, with an uppercase letter and a digit.
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Please choose a password.")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters.")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
            .Matches("[0-9]").WithMessage("Password must contain at least one digit.");
    }
}
