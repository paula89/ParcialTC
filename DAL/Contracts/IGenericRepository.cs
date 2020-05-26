using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        void Add(T o);

        void UpdateExtraer(string numero, string monto);
        void UpdateDepositar(string numero, string monto);
        void UpdateTransferir(string envia, string recibe, string monto);


        List<T> GetAll();
    }
}
