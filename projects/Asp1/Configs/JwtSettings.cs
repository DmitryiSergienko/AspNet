using System.ComponentModel.DataAnnotations;

namespace Asp1.Configs;

public class JwtSettings
{
    [Required(ErrorMessage = "Поле обязательно")]
    [MinLength(32, ErrorMessage = "Ключ должен быть минимум 32 символа")]
    public string Key { get; set; }
    [Required(ErrorMessage = "Поле обязательно")]
    public string Issuer { get; set; }
    [Required(ErrorMessage = "Поле обязательно")]
    public string Audience { get; set; }
    [Required(ErrorMessage = "Поле обязательно")]
    [Range(1, 1440, ErrorMessage = "Время жизни токена должно быть от 1 до 1440 минут")]
    public int AccessTokenLifetimeMinutes { get; set; }
    [Required(ErrorMessage = "Поле обязательно")]
    [Range(1, 365, ErrorMessage = "Время жизни refresh токена должно быть от 1 до 365 дней")]
    public int RefreshTokenLifetimeDays { get; set; }
}