using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WApp_001.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()/// Primeira Pagina
        {
            return View();
        }

        public ActionResult About()///Sobre
        {
            ViewBag.Message = "Conheça um pouco mais sobre nós";
            return View();
        }

        public ActionResult Contact()///Contato
        {
            ViewBag.Message = "Contato";
            return View();
        }

        public ActionResult Cadastro()///Cadastro
        {
            ViewBag.Message = "Cadastro de Produtos/Serviços";
            return View();
        }

        public ActionResult GaleriaFotos()///Galeria de Fotos
        {
            ViewBag.Message = "Galeria de Fotos";
            return View();
        }
        public ActionResult Agenda()///Agenda
        {
            ViewBag.Message = "Agenda";
            return View();
        }

        public ActionResult Carrinho()///Carrinho
        {
            ViewBag.Message = "Carrinho";
            return View();
        }
    }
}