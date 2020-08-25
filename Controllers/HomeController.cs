using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libs.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato(HttpContext.Request.Form["nome"], HttpContext.Request.Form["email"], HttpContext.Request.Form["texto"]);

                ContatoEmail.EnviarContatoPorEmail(contato);
                ViewData["MSG_SUCESSO"] = "Mensagem de contato enviada com sucesso!";
            }
            catch (Exception e)
            {
                ViewData["MSG_ERRO"] = "Ops! Aconteceu algo inesperado, tente novamente em alguns instantes!";
                
                //TODO - Implementar Log
            }

            return View("Contato");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}
