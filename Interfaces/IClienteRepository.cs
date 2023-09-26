using CSharpProjeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjeto01.Interfaces
{
    /// <summary>
    /// Interfaces para abstração de todos os métodos de repositório de dados relacionados aos clientes
    /// </summary>
    public interface IClienteRepository
    {
        #region Métodos abstratos
        void InsertClient(Cliente cliente);
        void UpdateClient(Cliente cliente);
        void DeleteClient(Cliente cliente);
        List<Cliente> GetAll();
        Cliente? GetById(Guid id);
        #endregion
    }
}
