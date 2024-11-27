namespace ProjetoBFP.Client
{
    public class BaseClient
    {
        protected readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:3000/") };
    }
}
