using Microsoft.AspNetCore.Mvc;

namespace Lamppit.Api.Controllers
{
    public class TesteController: Controller
    {
        [HttpGet("teste")]
        public IActionResult Teste()
        {
            return Ok("ta funcionando");
        }
    }
}