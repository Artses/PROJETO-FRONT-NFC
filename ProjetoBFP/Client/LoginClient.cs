using ProjetoBFP.Models;
using ProjetoBFP.Pages;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ProjetoBFP.Client
{
    public class LoginClient : BaseClient
    {
        public async Task<AuthResult> LoginAsync(Login loginModel)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var requestContent = new StringContent(
                JsonSerializer.Serialize(loginModel, options),
                Encoding.UTF8,
            "application/json");

            var response = await httpClient.PostAsync("auth/Login", requestContent);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return new AuthResult { Success = true, Message = content };
            }

            return new AuthResult
            {
                Success = false,
                Message = $"Falha no login. Verifique suas credenciais."
            };
        }
    }
}
