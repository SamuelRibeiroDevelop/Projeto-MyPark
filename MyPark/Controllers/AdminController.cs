using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPark.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult TipoVeiculo()
        {
            var tipoveiculos = DbFactory.Instance.TipoVeiculoRepository.FindAll();

            return View(tipoveiculos);
        }

        public ActionResult AddTipoVeiculo()
        {
            return View(new tipoveiculo());
        }

        public PartialViewResult GravarTipoVeiculo(tipoveiculo tipo)
        {
            DbFactory.Instance.TipoVeiculoRepository.SaveOrUpdate(tipo);

            var tipoveiculos = DbFactory.Instance.TipoVeiculoRepository.FindAll();

            return PartialView("_TabelaTipoVeiculo", tipoveiculos);
        }

        public PartialViewResult ExibirAddTipoVeiculo()
        {
            return PartialView("_AddTipoVeiculo", new tipoveiculo());
        }

        public ActionResult ApagarVeiculo(tipoveiculo tipo)
        {
            DbFactory.Instance.TipoVeiculoRepository.Delete(tipo);

            var tipoveiculos = DbFactory.Instance.TipoVeiculoRepository.FindAll();

            return PartialView("_TabelaTipoVeiculo", tipoveiculos);
        }

        public PartialViewResult EditarVeiculo(Guid id)
        {
            var tipoVeic = DbFactory.Instance.TipoVeiculoRepository.FindFirstById(id);

            return PartialView("_AddTipoVeiculo", tipoVeic);
        }
    }
}