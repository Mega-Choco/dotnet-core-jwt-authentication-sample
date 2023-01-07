namespace jwt_authentication_sample.Models.Request
{
    public class LoginRequest
    {
        /// <summary>
        /// 로그인 ID
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 로그인 비밀번호
        /// </summary>
        public string? Password { get; set; }
    }
}
