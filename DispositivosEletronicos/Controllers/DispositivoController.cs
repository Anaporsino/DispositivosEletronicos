using DispositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DispositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, ehlaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows11"},
                new Computador { Marca = "Samsung", Modelo = "Inspirion", AnoDeFabricacao = 2021, ehlaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows11"}
            };
            return View(dispositivos);
        }
    }
}
