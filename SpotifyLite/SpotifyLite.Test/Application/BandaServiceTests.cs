using AutoMapper;
using Moq;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Test.Application
{
    public class BandaServiceTests
    {
        [Fact]
        public async Task DeveCriarBandaComSucesso()
        {
            BandaInputDto dto = new BandaInputDto("XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");
            Mock<IBandaRepository> mockRepository = new Mock<IBandaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Banda banda = new Banda()
            {
                Descricao = "Lorem Ipsom",
                Foto = "lorem ipsum",
                Nome = "Xpto"
            };

            //mockMapper.Setup(x => x.Map<Banda>(dto)).Returns(banda);
            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dto);

            Assert.NotNull(result);

            
        }

    }
}
