using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public List<Cuenta> Cuentas {get; set;}

        public Cliente(List<Cuenta> cuentas = null)
        {
            this.Cuentas = (cuentas == null) ? new List<Cuenta>() : cuentas;
        }
    }
}
