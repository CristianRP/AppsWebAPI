using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppsWebAPI.Models
{
    public class Chequeo
    {
        public int Id { get; set; }
        public int CodigoSupervisor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string SistemaElectrico { get; set; }
        public string Cilindros { get; set; }
        public string BombaHD { get; set; }
        public string RodajeCadena { get; set; }
        public string Cuchilla { get; set; }
        public string Llantas { get; set; }
        public string Mangueras { get; set; }
        public string Sillones { get; set; }
        public string Vidrios { get; set; }
        public string Motor { get; set; }
        public string Otros { get; set; }
        public int CodigoMaquina { get; set; }

        public Chequeo()
        {
        }

        public Chequeo(int id, int codigoSupervisor, string nombreProveedor, DateTime fecha,
            string sistemaElectrico, string cilindros, string bombaHD, string rodajeCadena,
            string cuchilla, string llantas, string mangueras, string sillones, string vidrios,
            string motor, string otros, int codigoMaquina)
        {
            this.Id = id;
            this.CodigoSupervisor = codigoSupervisor;
            this.NombreProveedor = nombreProveedor;
            this.Fecha = fecha;
            this.SistemaElectrico = sistemaElectrico;
            this.Cilindros = cilindros;
            this.BombaHD = bombaHD;
            this.RodajeCadena = rodajeCadena;
            this.Cuchilla = cuchilla;
            this.Llantas = llantas;
            this.Mangueras = mangueras;
            this.Sillones = sillones;
            this.Vidrios = vidrios;
            this.Motor = motor;
            this.Otros = otros;
            this.CodigoMaquina = codigoMaquina;
        }
     }
}