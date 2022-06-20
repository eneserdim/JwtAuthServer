using AuthServer.Core.DTOS;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto); //Token Oluşturma.
        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken); //Yeni Refresh Token Alabilir Client.
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken); //Refresh Token'ı sonlandırma.
        Response<ClientTokenDto> CreateTokenByClient(ClientLoginDTo clientLoginDTo); //Client'a Yeni Token Oluşturma.



    }
}
