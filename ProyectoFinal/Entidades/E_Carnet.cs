using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class E_Carnet
    {
        public int nroCarnet {  get; set; }
        public DateTime fechaEmision {  get; set; }
        public DateTime? fechaVencimiento { get; set; }
        public int nroSocio {  get; set; }
    }
}
