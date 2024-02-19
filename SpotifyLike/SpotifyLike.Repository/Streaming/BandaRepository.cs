using SpotifyLike.Domain.Streaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Repository.Streaming
{
    public class BandaRepository
    {
        private SpotifyContext spotifyContext;

        public BandaRepository(SpotifyContext spotifyContext)
        {
            this.spotifyContext = spotifyContext;
        }

        public Musica GetMusica(Guid idMusica)
        {
            throw new NotImplementedException();
        }
    }
}
