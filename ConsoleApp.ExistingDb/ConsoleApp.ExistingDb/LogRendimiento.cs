using System;
using System.Collections.Generic;

namespace ConsoleApp.ExistingDb
{
    public class LogRendimiento
    {
        public decimal Id { get; set; }
        public string Ejecutor { get; set; }
        public string DatoEjecutado { get; set; }
        public DateTime? InicioEjecucion { get; set; }
        public DateTime? FinEjecucion { get; set; }
    }
}
