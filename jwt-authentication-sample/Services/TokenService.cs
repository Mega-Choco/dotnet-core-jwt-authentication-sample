namespace jwt_authentication_sample.Services
{
    public interface ITokenService
    {
        public string GenerateToken(string uid);
        public string GenerateRefreshToken(string token);
        public string ValidateToken(string token);
    }
    public class TokenService : ITokenService
    {
        public string GenerateToken(string uid)
        {
            throw new NotImplementedException();
        }

        public string GenerateRefreshToken(string token)
        {
            throw new NotImplementedException();
        }

        public string ValidateToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
