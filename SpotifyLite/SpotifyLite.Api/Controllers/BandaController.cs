using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;

namespace SpotifyLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private readonly IBandaService bandaService;

        public BandaController(IBandaService bandaService)
        {
            this.bandaService = bandaService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.bandaService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Criar(BandaInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await this.bandaService.Criar(dto);

            return Created($"/{result.Id}", result);
        }
    }
}
