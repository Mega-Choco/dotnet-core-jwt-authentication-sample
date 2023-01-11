using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace jwt_authentication_sample.Models.Request
{
    public class JoinRequest
    {
        /// <summary>
        /// 가입할 아이디
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 가입할 비밀번호
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 가입할 이름
        /// </summary>
        [NotNull]
        public string Name { get; set; }

        /*
        /// <summary>
        /// 프로필 이미지
        /// </summary>
        [FromForm]
        public FormFile? ProfileImage { get; set; }
        s*/
    }
}
