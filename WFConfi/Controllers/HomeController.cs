using Microsoft.AspNetCore.Mvc;
using WFConfi.Models;

namespace WFConfi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        private static List<Estado> listaEstado = new List<Estado>();

        [HttpGet("estado")]
        public IActionResult GetEstados()
        {
            return Ok(listaEstado);
        }

        [HttpPost("estado")]
        public IActionResult PostEstados([FromBody] Estado estado)
        {
            listaEstado.Add(estado);
            return Ok("Estado cadastrado com sucesso.");
        }



        [HttpGet]
        public IActionResult Index()
        {
            var result = "Estudo para construção de API Web";
            return Ok(result);
        }

/*        [HttpGet("info/{valor}")]
        public IActionResult GetInformacao(string valor)
        {
            var resultado = "Você digitou: " + valor;
            return Ok(resultado);
        }

        [HttpPost("info2/{valor}")]
        public IActionResult EnvioValor(string valor)
        {
            var resultado = "Você enviou: " + valor;
            return Ok(resultado);
        }*/

    }
}
