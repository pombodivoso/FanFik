using FanFik.Models;

namespace FanFik.UseCases.CreateAccount;

public class CreateAccountUseCase(FanFikDbContext ctx)
{
    public async Task<Result<CreateAccountResponse>> Do(CreateAccountPayload payload)
    {
        var name = ctx.User.FirstOrDefault(u => u.Username == payload.Username);

        if (name is not null)
            return Result<CreateAccountResponse>.Fail("Invalid Username!");

        var email = ctx.User.FirstOrDefault(u => u.Email == payload.Email);

        if (email is not null)
            return Result<CreateAccountResponse>.Fail("Invalid Email!");

        var user = new User
        {
            Username = payload.Username,
            Email = payload.Email,
            Bio = payload.Bio,
            Password = payload.Password,
            CreationDate = DateTime.Now
        };

        ctx.User.Add(user);
        await ctx.SaveChangesAsync();
        return Result<CreateAccountResponse>.Success(user.UserId);
    }
}