using System.Text.Json.Serialization;

namespace ProjetoBFP.Models
{
    public class Alunos
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("aluno")]
        public int AlunoId { get; set; }
        [JsonPropertyName("nome")]
        public string AlunoNome { get; set; }
        [JsonPropertyName("data")]
        public string? Data { get; set; }
        [JsonPropertyName("tipoChamada")]
        public string? Tipo { get; set; }
    }
}
