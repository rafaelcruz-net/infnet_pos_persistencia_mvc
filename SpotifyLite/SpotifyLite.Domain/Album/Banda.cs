using SpotifyLite.Domain.Album.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album
{
    public class Banda
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Descricao { get; set; }
        public IList<Album> Albums { get; set; }

        public void CreateAlbum(string nome, IList<Musica> musicas)
        {
            var album = AlbumFactory.Create(nome, musicas);
            this.Albums.Add(album); 
        }

        public int QuantidadeAlbuns() 
            => this.Albums.Count;

        public IEnumerable<Musica> ObterMusicas()
            => this.Albums.SelectMany(x => x.Musicas).AsEnumerable();

    }
}
