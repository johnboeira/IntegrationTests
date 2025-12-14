using System.ComponentModel.DataAnnotations;

namespace eCommerce.MinimalApi.Models.Authentication;

public record LoginRequest(
    [Required] string UserName,
    [Required] string Password);