using SpotifyLike.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Repository.Conta
{
    public class UsuarioRepository
    {
        private SpotifyContext spotifyContext;

        public UsuarioRepository(SpotifyContext spotifyContext)
        {
            this.spotifyContext = spotifyContext;
        }

        public void Save(Usuario usuario)
        {
            this.spotifyContext.Usuarios.Add(usuario);
            this.spotifyContext.SaveChanges();  
        }

        public Usuario GetUsuario(Guid id)
        {
            return this.spotifyContext.Usuarios
                                      .Where(x => x.Id == id)
                                      .FirstOrDefault();
        }

        public void Update(Usuario usuario)
        {
            this.spotifyContext.Usuarios.Update(usuario);
            this.spotifyContext.SaveChanges();
        }

        public void Remove(Usuario usuario)
        {
            this.spotifyContext.Usuarios.Remove(usuario);
            this.spotifyContext.SaveChanges();
        }

    }
}
