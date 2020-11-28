using AutoMapper;
using EsteEs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using EsteEs.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EsteEs.Controllers
{
    public class EditController : Controller
    {

        private readonly ILogger<EditController> _logger;
        private readonly IglesiaDBContext dbcontext;
        private readonly IMapper mapeador;
        private readonly IHostingEnvironment hosting;

        public EditController(IglesiaDBContext db, ILogger<EditController> logger, IMapper mapa, IHostingEnvironment jost)
        {
            _logger = logger;
            dbcontext = db;
            mapeador = mapa;
            hosting = jost;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Editar()
        {

            return View();
        }


        public ActionResult EditPersonal(int id)
        {
            var integr = dbcontext.Integrantes.Find(id);
            return View(integr);
        }
        [HttpPost]
        public async Task<ActionResult> EditPersonal(Integrantes inte, IFormFile imagen)
        {
            DetallesViewModel detalle = new DetallesViewModel();

           // detalle.Borrar(Path.Combine(hosting.WebRootPath, "/images" + inte.Imagen));


            string Subir = Path.Combine(hosting.WebRootPath, "images");
            string FileName = Guid.NewGuid().ToString() + "_" + imagen.FileName;
            string FilePath = Path.Combine(Subir, FileName);
            imagen.CopyTo(new FileStream(FilePath, FileMode.Create));

            inte.Imagen = "images/" + FileName;
            dbcontext.Integrantes.Update(inte);

            await dbcontext.SaveChangesAsync();

            return RedirectToAction("Lista","Home");
        }
        public ActionResult EditFam(int id)
        {
            var familiar = dbcontext.DatosFamiliares.FirstOrDefault(x => x.IdIntegrante == id);
            return View(familiar);
        }
        [HttpPost]
        public async Task<ActionResult> EditFam(DatosFamiliares datofam)
        {
            var data = dbcontext.DatosFamiliares.Find(datofam.Id);
            data.Hijos = datofam.Hijos;
            data.EstadoCivil = datofam.EstadoCivil;
            dbcontext.DatosFamiliares.Update(data);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Lista", "Home");
        }


        public ActionResult EditLab(int id)
        {
            var laboral = dbcontext.DatosLaborales.FirstOrDefault(x => x.IdIntegrante == id);
            return View(laboral);
        }
        [HttpPost]
        public ActionResult EditLab(DatosLaborales DatoLab)
        {
            var data = dbcontext.DatosLaborales.Find(DatoLab.Id);
            data.NombreEmpresa = DatoLab.NombreEmpresa;
            data.Ocupacion = DatoLab.Ocupacion;
            data.Profesion = DatoLab.Profesion;
            data.Telefono = DatoLab.Profesion;
            dbcontext.DatosLaborales.Update(data);
            dbcontext.SaveChanges();
            return RedirectToAction("Lista", "Home");
        }


        public ActionResult EditEcl(int id)
        {
            var eclesia = dbcontext.DatosEclesiasticos.FirstOrDefault(x => x.IdIntegrante == id);
            return View(eclesia);
        }
        [HttpPost]
        public ActionResult EditEcl(DatosEclesiasticos DatoEcl)
        {
            var data = dbcontext.DatosEclesiasticos.Find(DatoEcl.Id);
            data.CongregacionAnterior = DatoEcl.CongregacionAnterior;
            data.Denominacion = DatoEcl.Denominacion;
            data.Disciplinado = DatoEcl.Disciplinado;
            data.DisciplinadoCausas = DatoEcl.DisciplinadoCausas;
            data.DisciplinadoVeces = DatoEcl.DisciplinadoVeces;
            data.FechaAceptado = DatoEcl.FechaAceptado;
            data.FechaBautismo = DatoEcl.FechaBautismo;
            data.FechaConversion = DatoEcl.FechaConversion;
            data.Funciones = DatoEcl.Funciones;
            data.Metas = DatoEcl.Metas;
            data.Ministerios = DatoEcl.Ministerios;
            data.MinisteriosLlamado = DatoEcl.MinisteriosLlamado;
            data.MinisteriosMayorFruto = DatoEcl.MinisteriosMayorFruto;
            data.NombreIglesia = DatoEcl.NombreIglesia;
            data.Pastor = DatoEcl.Pastor;
            data.Respaldo = DatoEcl.Respaldo;
            dbcontext.DatosEclesiasticos.Update(data);
            dbcontext.SaveChanges();
            return RedirectToAction("Lista", "Home");
        }


        public ActionResult EditAcad(int id)
        {
            var academico = dbcontext.DatosAcademicos.FirstOrDefault(x => x.IdIntegrante == id);
            return View(academico);
        }
        [HttpPost]
        public ActionResult EditAcad(DatosAcademicos datoAc)
        {
            var data = dbcontext.DatosAcademicos.Find(datoAc.Id);
            data.NivelEstudio = datoAc.NivelEstudio;
            data.Expulsado = datoAc.Expulsado;
            dbcontext.DatosAcademicos.Update(data);
            dbcontext.SaveChanges();
            return RedirectToAction("Lista", "Home");
        }

       
    }
}
