using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            List<Contato> contatos = new();
            contatos.Add(new Contato() { Id = 1, Nome = "Magali", Email = "magali@gmail.com" });
            contatos.Add(new Contato() { Id = 2, Nome = "Monica", Email = "monica@gmail.com" });
            contatos.Add(new Contato() { Id = 3, Nome = "Cebolinha", Email = "cebolinha@gmail.com" });
            contatos.Add(new Contato() { Id = 4, Nome = "Cascão", Email = "cascao@gmail.com" });
            return View(contatos);
        }
    }
}
