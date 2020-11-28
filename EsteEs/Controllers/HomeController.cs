using EsteEs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EsteEs.ViewModels;
namespace EsteEs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IglesiaDBContext dbcontext;
        private readonly IMapper mapeador;
        public HomeController(IglesiaDBContext db, ILogger<HomeController> logger, IMapper mapa)
        {
            _logger = logger;
            dbcontext = db;
            mapeador = mapa;
        }



        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult>  Index(Integrantes inte)
        {

        await dbcontext.Integrantes.AddAsync(inte);
            
           await dbcontext.SaveChangesAsync();
            
            DatosFamiliares DataF = new DatosFamiliares();
            DataF.IdIntegrante = inte.Id;
            return RedirectToAction("Index1","Home", DataF);
        }
        public ActionResult Index1(DatosFamiliares Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult Index1(int ide, DatosFamiliares DatoFam)
        {
           
            dbcontext.DatosFamiliares.Add(DatoFam);
            dbcontext.SaveChanges();

            DatosLaborales DatoLab = new DatosLaborales();
            DatoLab.IdIntegrante = DatoFam.IdIntegrante;
            return RedirectToAction("Index2", "Home", DatoLab);
        }


        public ActionResult Index2(DatosLaborales Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult Index2(int ide, DatosLaborales DatoLab)
        {
            
            dbcontext.DatosLaborales.Add(DatoLab);
            dbcontext.SaveChanges();

            DatosEclesiasticos DatoEcl = new DatosEclesiasticos();
            DatoEcl.IdIntegrante = DatoLab.IdIntegrante;
            return RedirectToAction("Index3", "Home", DatoEcl);
        }


        public ActionResult Index3(DatosEclesiasticos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult Index3(int ide, DatosEclesiasticos DatoEcl)
        {

            dbcontext.DatosEclesiasticos.Add(DatoEcl);
            dbcontext.SaveChanges();
            DatosAcademicos DatoAc = new DatosAcademicos();
            DatoAc.IdIntegrante = DatoEcl.IdIntegrante;
            return RedirectToAction("Index4","Home", DatoAc);
        }


        public ActionResult Index4(DatosAcademicos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult Index4(int ide, DatosAcademicos datoAc)
        {

            dbcontext.DatosAcademicos.Add(datoAc);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Lista()
        {

            var lista = dbcontext.Integrantes.ToList();
            return View(lista);
        }
        public ActionResult Detalles(int id)
        {
            var integrante=dbcontext.Integrantes.Find(id);
            var laboral = dbcontext.DatosLaborales.FirstOrDefault(x => x.IdIntegrante == id);
            var familiar = dbcontext.DatosFamiliares.FirstOrDefault(x => x.IdIntegrante == id);
            var academico = dbcontext.DatosAcademicos.FirstOrDefault(x => x.IdIntegrante == id);
            var eclesia = dbcontext.DatosEclesiasticos.FirstOrDefault(x => x.IdIntegrante == id);


            DetallesViewModel detalle = new DetallesViewModel();
            detalle.integrante = integrante;
            detalle.datolab = laboral;
            detalle.datofam = familiar;
            detalle.datoecl = eclesia;
            detalle.datoac = academico;
            return View(detalle);
        }

        public ActionResult Eliminar(int id)
        {
            var integrante = dbcontext.Integrantes.Find(id);
            var laboral = dbcontext.DatosLaborales.FirstOrDefault(x => x.IdIntegrante == id);
            var familiar = dbcontext.DatosFamiliares.FirstOrDefault(x => x.IdIntegrante == id);
            var academico = dbcontext.DatosAcademicos.FirstOrDefault(x => x.IdIntegrante == id);
            var eclesia = dbcontext.DatosEclesiasticos.FirstOrDefault(x => x.IdIntegrante == id);

            dbcontext.DatosLaborales.Remove(laboral);
            dbcontext.DatosFamiliares.Remove(familiar);
            dbcontext.DatosEclesiasticos.Remove(eclesia);
            dbcontext.DatosAcademicos.Remove(academico);
            dbcontext.Integrantes.Remove(integrante);
            dbcontext.SaveChanges();
            return RedirectToAction("Lista");
        }

        public ActionResult Editar()
        {
           
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }







        public ActionResult EditPersonal(int id)
        {
            var integr=dbcontext.Integrantes.Find(id);
            return View(integr);
        }
        [HttpPost]
        public async Task<ActionResult> EditPersonal(Integrantes inte)
        {

            dbcontext.Integrantes.Update(inte);

            await dbcontext.SaveChangesAsync();

            return RedirectToAction("Lista");
        }
        public ActionResult EditFam(DatosFamiliares Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult EditFam(int ide, DatosFamiliares DatoFam)
        {

            dbcontext.DatosFamiliares.Add(DatoFam);
            dbcontext.SaveChanges();

            DatosLaborales DatoLab = new DatosLaborales();
            DatoLab.IdIntegrante = DatoFam.IdIntegrante;
            return RedirectToAction("Index2", "Home", DatoLab);
        }


        public ActionResult EditLab(DatosLaborales Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult EditLab(int ide, DatosLaborales DatoLab)
        {

            dbcontext.DatosLaborales.Add(DatoLab);
            dbcontext.SaveChanges();

            DatosEclesiasticos DatoEcl = new DatosEclesiasticos();
            DatoEcl.IdIntegrante = DatoLab.IdIntegrante;
            return RedirectToAction("Index3", "Home", DatoEcl);
        }


        public ActionResult EditEcl(DatosEclesiasticos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult EditEcl(int ide, DatosEclesiasticos DatoEcl)
        {

            dbcontext.DatosEclesiasticos.Add(DatoEcl);
            dbcontext.SaveChanges();
            DatosAcademicos DatoAc = new DatosAcademicos();
            DatoAc.IdIntegrante = DatoEcl.IdIntegrante;
            return RedirectToAction("Index4", "Home", DatoAc);
        }


        public ActionResult EditAcad(DatosAcademicos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult EditAcad(int ide, DatosAcademicos datoAc)
        {

            dbcontext.DatosAcademicos.Add(datoAc);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
