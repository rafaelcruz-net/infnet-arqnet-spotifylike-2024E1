using SpotifyLike.Domain.Transacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Repository.Transacao
{
    public class PlanoRepository
    {
        private SpotifyContext spotifyContext;

        public PlanoRepository(SpotifyContext spotifyContext)
        {
            this.spotifyContext = spotifyContext;
        }

        public Plano GetPlanoById(Guid planoId)
        {
            throw new NotImplementedException();
        }
    }
}
