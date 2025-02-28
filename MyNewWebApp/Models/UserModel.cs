using System.ComponentModel.DataAnnotations;

namespace MyNewWebApp.Models
{
  public class UserModel
  {
    [Required(ErrorMessage = "名前は必須です")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "メールアドレスは必須です")]
    [EmailAddress(ErrorMessage = "無効なメールアドレスです")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "パスワードは必須です")]
    [MinLength(6, ErrorMessage = "パスワードは6文字以上である必要があります")]
    public required string Password { get; set; }
  }
}
