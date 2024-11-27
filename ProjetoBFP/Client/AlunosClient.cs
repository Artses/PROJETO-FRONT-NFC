using Microsoft.Extensions.Options;
using ProjetoBFP.Models;
using System.Text.Json;

namespace ProjetoBFP.Client
{
    public class AlunosClient : BaseClient
    {
        public async Task<List<Alunos>> GetChamadas()
        {
            HttpResponseMessage resp = await httpClient.GetAsync("chamada");
            if (!resp.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao buscar chamadas: {resp.StatusCode}");
            }
            var content = await resp.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Alunos>>(content);
        }
    }
}
