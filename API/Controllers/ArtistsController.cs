using Aplication.Contracts;
using Aplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _service;

        public ArtistsController(IArtistService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("artist/{id}")]
        public async Task<IActionResult> GetArtistById([FromRoute] int id)
        {
            var artist = await _service.GetArtistAsync(id);
            if (artist != null)
            {
                return Ok(artist);
            }else
            {
                return NoContent();
            }
        }
    }
}
