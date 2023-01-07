namespace jwt_authentication_sample.Models.Response
{
    public class LoginResponse
    {

        /// <summary>
        /// JWT 토큰
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 리프레시 토큰
        /// </summary>
        public string RefreshToken { get; set; }
    }
}
