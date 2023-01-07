using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace jwt_authentication_sample.Models.Data
{
    public class Account
    {

        /// <summary>
        /// 계정 고유 ID
        /// </summary>
        [Key]
        [Required]
        [NotNull]
        public Guid Uid { get; set; } = Guid.NewGuid();


        /// <summary>
        /// 계정 ID
        /// </summary>
        [Required]
        [NotNull]
        public string Id { get; set; } 

        /// <summary>
        /// 비밀번호
        /// </summary>
        [Required]
        [NotNull]
        public string Password { get; set; }

        /// <summary>
        /// 계정의 이름
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 프로필 이미지의 URL
        /// </summary>
        public string? ProfileImageUrl { get; set; }

        /// <summary>
        /// 리프레시 토큰
        /// </summary>
        public string? RefreshToken { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}