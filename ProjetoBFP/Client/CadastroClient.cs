using ProjetoBFP.Models;
using System.Text.Json;
using System.Text;

namespace ProjetoBFP.Client
{
    public class CadastroClient : BaseClient
    {
        public async Task<AuthResult> CadastrarAsync(Cadastro cadastro)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var requestContent = new StringContent(
                JsonSerializer.Serialize(cadastro, options),
                Encoding.UTF8,
            "application/json");

            var response = await httpClient.PostAsync("auth/register", requestContent);

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
