using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Domain.Streaming
{
    public class Musica
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        //Todo: CORRIGIR!!!
        public int Duracao { get; set; }

        public Album Album { get; set; }

    }
}
