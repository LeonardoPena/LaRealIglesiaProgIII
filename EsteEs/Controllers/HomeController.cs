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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace EsteEs.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IglesiaDBContext dbcontext;
        private readonly IMapper mapeador;
        private readonly IHostingEnvironment hosting;
        public HomeController(IglesiaDBContext db, ILogger<HomeController> logger, IMapper mapa, IHostingEnvironment jost)
        {
            _logger = logger;
            dbcontext = db;
            mapeador = mapa;
            hosting=jost;
        }



        // GET: HomeController1
        public ActionResult DatosPersonales()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DatosPersonales(Integrantes inte, IFormFile imagen)
        {
            string Subir = Path.Combine(hosting.WebRootPath, "images");
            string FileName = Guid.NewGuid().ToString() + "_" + imagen.FileName;
            string FilePath = Path.Combine(Subir, FileName);
            imagen.CopyTo(new FileStream(FilePath, FileMode.Create));

            inte.Imagen = "images/"+FileName;


           await dbcontext.Integrantes.AddAsync(inte);
           
           await dbcontext.SaveChangesAsync();
            
            DatosFamiliares DataF = new DatosFamiliares();
            DataF.IdIntegrante = inte.Id;
            return RedirectToAction("DatosFamiliares", "Home", DataF);
        }
        public ActionResult DatosFamiliares(DatosFamiliares Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult DatosFamiliares(int ide, DatosFamiliares DatoFam)
        {
           
            dbcontext.DatosFamiliares.Add(DatoFam);
            dbcontext.SaveChanges();

            DatosLaborales DatoLab = new DatosLaborales();
            DatoLab.IdIntegrante = DatoFam.IdIntegrante;
            return RedirectToAction("DatosLaborales", "Home", DatoLab);
        }


        public ActionResult DatosLaborales(DatosLaborales Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult DatosLaborales(int ide, DatosLaborales DatoLab)
        {
            
            dbcontext.DatosLaborales.Add(DatoLab);
            dbcontext.SaveChanges();

            DatosEclesiasticos DatoEcl = new DatosEclesiasticos();
            DatoEcl.IdIntegrante = DatoLab.IdIntegrante;
            return RedirectToAction("DatosEclesiasticos", "Home", DatoEcl);
        }


        public ActionResult DatosEclesiasticos(DatosEclesiasticos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult DatosEclesiasticos(int ide, DatosEclesiasticos DatoEcl)
        {

            dbcontext.DatosEclesiasticos.Add(DatoEcl);
            dbcontext.SaveChanges();
            DatosAcademicos DatoAc = new DatosAcademicos();
            DatoAc.IdIntegrante = DatoEcl.IdIntegrante;
            return RedirectToAction("DatosAcademicos", "Home", DatoAc);
        }


        public ActionResult DatosAcademicos(DatosAcademicos Data)
        {
            ViewBag.id_integrante = Data.IdIntegrante;
            return View();
        }
        [HttpPost]
        public ActionResult DatosAcademicos(int ide, DatosAcademicos datoAc)
        {

            dbcontext.DatosAcademicos.Add(datoAc);
            dbcontext.SaveChanges();
            return RedirectToAction("Lista");
        }
        public ActionResult Lista()
        {
            ViewData["Nombre"] = User.Identity.Name;
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

        
        public IActionResult Privacy()
        {
            return View();
        }







 




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
