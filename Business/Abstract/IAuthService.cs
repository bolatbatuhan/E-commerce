using CorePackages.Entities.Concrete;
using CorePackages.Utilities.Results;
using CorePackages.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract;

public interface IAuthService
{
    IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
    IDataResult<User> Login(UserForLoginDto userForLoginDto);
    IResult UserExists(string email);
    IDataResult<AccessToken> CreateAccessToken(User user);
}
