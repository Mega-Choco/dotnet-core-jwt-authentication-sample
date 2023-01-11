using jwt_authentication_sample.Exceptions;
using jwt_authentication_sample.Models.Request;
using jwt_authentication_sample.Models.Response;
using System.Reflection.Metadata.Ecma335;
using jwt_authentication_sample.Models.Data;

namespace jwt_authentication_sample.Services
{

    public interface IAuthService
    {
        public Task<LoginResponse> JoinAsync(JoinRequest model);
        public Task<LoginResponse> LoginAsync(LoginRequest model);
    }

    public class AuthService : IAuthService
    {
        private readonly DatabaseContext databaseContext;

        public AuthService(DatabaseContext _databaseContext)
        {
            this.databaseContext = _databaseContext;
        }

        public async Task<LoginResponse> JoinAsync(JoinRequest model)
        {
            /*  if(model.Id == null)
           {
                throw new ApiException(StatusCodes.Status400BadRequest, "아이디를 입력해 주세요.");
           }*/

           var account = new Account()
           {
               Id = model.Id,
               Name = model.Name,
               Password = model.Password,

           };

           databaseContext.Accounts.Add(account);
           await databaseContext.SaveChangesAsync();

           return null;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
