using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPark.Controllers
{
    public class PlanosController : Controller
    {
        // GET: Planos
        public ActionResult Planos()
        {
            var planos = DbFactory.Instance.PlanoRepository.FindAll();

            return View(planos);
        }

        public PartialViewResult GravarPlano(plano Plano)
        {
            DbFactory.Instance.PlanoRepository.Save(Plano);

            var planos = DbFactory.Instance.PlanoRepository.FindAll();

            return PartialView("_TabelaPlanos",planos);
        }

        public PartialViewResult ExibrirAddPlano()
        {
            return PartialView("_AddPlanos",new plano());
        }

        public ActionResult ApagarPlano(plano Plano)
        {
            DbFactory.Instance.PlanoRepository.Delete(Plano);

            var planos = DbFactory.Instance.PlanoRepository.FindAll();

            return PartialView("_TabelaPlanos", planos);
        }
    }
}