using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppsWebAPI.Models
{
    public class Reparacion
    {
        public DateTime FechaParalizacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string EstadoReparacion { get; set; }
        public DateTime FechaFin { get; set; }
        public int DiasAsignados { get; set; }
        public int CodigoMaquina { get; set; }
        public string Diagnostico { get; set; }

        public Reparacion() { }

        public Reparacion(DateTime fechaParalizacion, DateTime fechaInicio, 
            string estadoReparacion, DateTime fechaFin, int diasAsignados,
            int codigoMaquina, string diagnostico)
        {
            this.FechaParalizacion = fechaParalizacion;
            this.FechaInicio = fechaInicio;
            this.EstadoReparacion = estadoReparacion;
            this.FechaFin = fechaFin;
            this.DiasAsignados = diasAsignados;
            this.CodigoMaquina = codigoMaquina;
            this.Diagnostico = diagnostico;
        }
    }
}