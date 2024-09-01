using FluentValidation;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty().WithMessage("First name is required.");
        RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name is required.");
        RuleFor(c => c.Email).NotEmpty().EmailAddress().WithMessage("A valid email is required.");
        RuleFor(c => c.Password).NotEmpty().WithMessage("Password is required.");
    }
}
