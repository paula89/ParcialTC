using DAL.Contracts;
using DomainModel;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Memory
{
    public class ClienteRepository: IGenericRepository<Cliente>
    {
        public List<Cliente> clientesCuentas { get; set; }


        public ClienteRepository()
        {
            clientesCuentas = new List<Cliente>();

            CuentaCorriente cuentaCorriente = new CuentaCorriente()
            {
                Numero = "123",
                Saldo = 100
            };
            CajaDeAhorro cajaDeAhorro = new CajaDeAhorro()
            {
                Numero = "456",
                Saldo = 200
            };

            List<Cuenta> cuentas = new List<Cuenta>();
            cuentas.Add(cuentaCorriente);
            cuentas.Add(cajaDeAhorro);

            Cliente cliente1 = new Cliente(cuentas);
            cliente1.Nombre = "Cliente 1";

            Add(cliente1);
        }

             

        List<Cliente> IGenericRepository<Cliente>.GetAll()
        {
            return clientesCuentas;
        }

        public void Add(Cliente o)
        {
            clientesCuentas.Add(o);
        }

        public void UpdateExtraer(string cuenta, string monto)
        {

            foreach(var client in clientesCuentas)
            {
                foreach (var cuentaCliente in client.Cuentas) {
                    if (cuentaCliente.Numero == cuenta) {

                        cuentaCliente.Saldo -= System.Convert.ToDouble(monto);
                    }
                }

            }
        }
        public void UpdateDepositar(string cuenta, string monto)
        {
            foreach (var client in clientesCuentas)
            {
                foreach (var cuentaCliente in client.Cuentas)
                {
                    if (cuentaCliente.Numero == cuenta)
                    {

                        cuentaCliente.Saldo += System.Convert.ToDouble(monto);
                    }
                }

            }
        }
        public void UpdateTransferir(string envia, string recibe, string monto)
        {
            foreach (var client in clientesCuentas)
            {
                foreach (var cuentaCliente in client.Cuentas)
                {
                    if (cuentaCliente.Numero == recibe)
                    {
                        cuentaCliente.Saldo += System.Convert.ToDouble(monto);
                    }
                    if (cuentaCliente.Numero == envia)
                    { 
                        cuentaCliente.Saldo -= System.Convert.ToDouble(monto);
                    }
                }

            }
        }
    }
}
