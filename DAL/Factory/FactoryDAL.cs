using DAL.Contracts;
using DAL.Repositories.Memory;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace DAL.Factory
{
    public sealed class FactoryDAL
    {
        private readonly static FactoryDAL instance = new FactoryDAL();

        public static FactoryDAL Current
        {
            get
            {
                return instance;
            }
        }

        private FactoryDAL()
        {
        }
        public object GetClienteRepository()
        {

            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".ClienteRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return (IGenericRepository<Cliente>)instancia;
        }      
      
    }
}
