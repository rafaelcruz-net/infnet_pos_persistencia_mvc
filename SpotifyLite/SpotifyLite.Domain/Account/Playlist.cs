using SpotifyLite.CrossCutting.Entity;
using SpotifyLite.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Account
{
    public class Playlist : Entity<Guid>
    {
        public string Nome { get; set; }
        public virtual IList<Musica> Musicas { get; set; }
    }
}
