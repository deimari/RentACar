using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<AccessToken> CreateAccessToken(User user);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IResult UserExists(string email);
    }
}
