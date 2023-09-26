using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjeto01.Settings
{
    /// <summary>
    /// Definições para conexão com banco de dados do SqlServer
    /// </summary>
    public class SqlServerSettings
    {
        /// <summary>
        /// Método para retornar o caminho da conexão do banco de dados
        /// </summary>
        /// <returns>Connection String</returns>
        public static string GetConnectionString() 
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

    }
}
