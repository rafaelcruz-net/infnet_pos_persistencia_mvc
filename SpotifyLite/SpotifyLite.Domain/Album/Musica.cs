using SpotifyLite.CrossCutting.Entity;
using SpotifyLite.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album
{
    public class Musica : Entity<Guid>
    {
        public string Nome { get; set; }
        public Duracao Duracao { get; set; }
    }
}
