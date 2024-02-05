using SpotifyLike.Domain.Transacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Domain.Conta
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Assinatura> Assinaturas { get; set; }

    }
}
