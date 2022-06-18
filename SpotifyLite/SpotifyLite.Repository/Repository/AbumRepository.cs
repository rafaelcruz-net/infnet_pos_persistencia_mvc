using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using SpotifyLite.Repository.Context;
using SpotifyLite.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Repository
{
    public class AbumRepository : Repository<Album>, IAlbumRepository
    {
        public AbumRepository(SpotifyContext context) : base(context)
        {
            
        }

    }
}
