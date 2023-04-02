using Microsoft.AspNetCore.Mvc;
using Puc.Mercadinho.Api.Application;

namespace Puc.Mercadinho.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoApplication _produtoApplication;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutoController(
            ILogger<ProdutoController> logger, 
            IProdutoApplication produtoApplication,
            IWebHostEnvironment environment)
        {
            _logger = logger;
            _produtoApplication = produtoApplication;
            _hostEnvironment = environment;
        }

        [HttpGet("listar-todos")]
        public IActionResult ListarTodos()
        {
            try
            {
                if (Request.Headers["Authorization"] != "C47EE546-3D7C-4ED7-8D9D-FE4EA888342C")
                {
                    return Unauthorized();
                }

                var result = _produtoApplication.ObterTodosProdutos();

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("testar")]
        public IActionResult Testar()
        {
            try
            {

                var result = "Esta API está funcionando!!";

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //[HttpGet("obter-url-img")]
        //public IActionResult ObterUrlImg(string fileName)
        //{
        //    try
        //    {
        //        var path = Path.Combine(_hostEnvironment.WebRootPath, fileName);
        //        byte[] b = System.IO.File.ReadAllBytes(path);
        //        var result = "data:image/png;base64," + Convert.ToBase64String(b);

        //        return Ok(result);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}