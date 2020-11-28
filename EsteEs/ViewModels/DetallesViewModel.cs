using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EsteEs.Models;
namespace EsteEs.ViewModels
{
    public class DetallesViewModel
    {
        public Integrantes integrante;
        public DatosAcademicos datoac;
        public DatosEclesiasticos datoecl;
        public DatosFamiliares datofam;
        public DatosLaborales datolab;

        public void Borrar(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete(path);
        }
    }

}
