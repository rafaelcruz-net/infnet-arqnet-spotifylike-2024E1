using SpotifyLike.Domain.Streaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyLike.Repository.Streaming
{
    public class BandaRepository
    {
        private SpotifyContext spotifyContext;
        private HttpClient client;

        public BandaRepository(SpotifyContext spotifyContext, HttpClient client)
        {
            this.spotifyContext = spotifyContext;
            this.client = client;
        }

        public Musica GetMusica(Guid idMusica)
        {
            string baseUrl = $"http://localhost:8080/musica/{idMusica}";

            var response = client.GetAsync(baseUrl).Result;

            if (response.IsSuccessStatusCode == false)
                throw new Exception("Não consegui pesquisar a musica");

            var content = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<Musica>(content);

        }
    }
}
