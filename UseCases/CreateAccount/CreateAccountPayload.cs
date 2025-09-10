using System.ComponentModel.DataAnnotations;

namespace FanFik.UseCases.CreateAccount;

public record CreateAccountPayload
{
    [Required]
    public string Username { get; init; }

    [Required]
    public string Email { get; init; }

    [Required]
    public string Password { get; init; }

    public string Bio { get; init; }
}