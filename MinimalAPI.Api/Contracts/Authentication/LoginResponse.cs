namespace eCommerce.MinimalApi.Contracts.Authentication;

public class LoginResponse(string token)
{
    public string Token { get; init; } = token;
};