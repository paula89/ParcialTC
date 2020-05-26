using DomainModel;
using System.Collections.Generic;
using DAL.Factory;

namespace BLL
{
    public sealed class BLL
    {

        public IEnumerable<Cliente> GetAll()
        {
            //IGenericRepository<Customer> clientes = Factory.Current.GetCustomerRepository();
            //return clientes.GetAll();

            return FactoryDAL.Current.GetClienteRepository().GetAll();
        }




    }
}
