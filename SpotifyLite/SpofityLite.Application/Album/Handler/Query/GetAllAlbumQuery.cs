using MediatR;
using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Query
{
    public class GetAllAlbumQuery : IRequest<GetAllAlbumQueryResponse>
    {

    }

    public class GetAllAlbumQueryResponse 
    {
        public IList<AlbumOutputDto> Albums { get; set; }

        public GetAllAlbumQueryResponse(IList<AlbumOutputDto> albums)
        {
            Albums = albums;
        }
    }
}
