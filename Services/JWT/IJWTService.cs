namespace FanFik.Services.JWT;

public interface IJWTService
{
    string CreateToken(ProfileToAuth data); 
}