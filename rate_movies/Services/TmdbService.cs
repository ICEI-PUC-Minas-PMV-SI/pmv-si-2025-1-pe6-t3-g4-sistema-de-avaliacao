using rate_movies.Models;
using System.Text.Json;

namespace rate_movies.Services
{
    public class TmdbService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public TmdbService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["TMDB:ApiKey"]; // Pegando a chave do arquivo appsettings.json
        }

        public async Task<Filme> ObterFilmePorId(int idFilme)
        {
            string url = $"https://api.themoviedb.org/3/movie/{idFilme}?api_key={_apiKey}&language=pt-BR";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null; // Retorna nulo se não encontrar o filme
            }

            string json = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            return new Filme
            {
                IdFilme = root.GetProperty("id").GetInt32(),
                Nome = root.GetProperty("title").GetString(),
                Genero = root.GetProperty("genres")[0].GetProperty("name").GetString(),
                Nota = root.GetProperty("vote_average").GetDecimal(),
                FotoUrl = $"https://image.tmdb.org/t/p/w500{root.GetProperty("poster_path").GetString()}"
            };
        }
    }
}
