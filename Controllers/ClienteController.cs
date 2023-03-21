using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("Cliente")]
    //[Route("[controller]")] pega o nome da controller de forma dinâmica
    public class ClienteController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Vitor");
        }
    }
}