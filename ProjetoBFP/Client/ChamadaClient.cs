using ProjetoBFP.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace ProjetoBFP.Client
{
    public class ChamadaClient : BaseClient
    {
        public async Task<bool> InserirChamadaAsync(Chamada chamada)
        {
            chamada.Professor = 1;

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var requestContent = new StringContent(
                JsonSerializer.Serialize(chamada, options),
            Encoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync("chamada", requestContent);
            return response.IsSuccessStatusCode;
        }
    }
}
