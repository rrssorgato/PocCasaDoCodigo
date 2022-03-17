using CasaDoCodigo.Api.DataTransferObjects.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Add(AuthorRequest request)
        {
            // Sua implementação aqui
            // ControllerBase.Created em caso de sucesso
            // ControllerBase.BadRequest em caso de falha
            return Ok();
        }
    }
}