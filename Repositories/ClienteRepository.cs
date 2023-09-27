using CSharpProjeto01.Entities;
using CSharpProjeto01.Interfaces;
using CSharpProjeto01.Settings;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjeto01.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public void DeleteClient(Cliente cliente)
        {
            var query = @"DELETE FROM CLIENTE
                          WHERE
                            ID = @Id";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionString()))
            {
                connection.Execute(query, new
                {
                    @Id = cliente.Id,
                });
            }
        }

        public List<Cliente> GetAll()
        {
           
            var query = @"SELECT ID, NOME, CPF, EMAIL, DATANASCIMENTO FROM CLIENTE
                          ORDER BY NOME ASC
            ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionString())) 
            {
                return connection.Query<Cliente>(query).ToList();
            }
        }

        public Cliente? GetById(Guid id)
        {
            var query = @"SELECT ID, NOME, CPF, EMAIL, DATANASCIMENTO FROM CLIENTE
                          WHERE
                          ID = @Id
                        ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionString()))
            {
                return connection.Query<Cliente>(query, new
                {
                    @Id = id
                }).FirstOrDefault();
            }
        }

        public void InsertClient(Cliente cliente)
        {
            var query = @"INSERT INTO CLIENTE(ID, NOME, CPF, EMAIL, DATANASCIMENTO)
                          VALUES(@Id, @Nome, @Cpf, @Email, @DataNascimento)
                        ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionString()))
            {
                connection.Execute(query, new
                {
                    @Id = cliente.Id,
                    @Nome = cliente.Nome,
                    @Cpf = cliente.Cpf,
                    @Email = cliente.Email,
                    @DataNascimento = cliente.DataNascimento
                });
            }
        }

        public void UpdateClient(Cliente cliente)
        {
            var query = @"UPDATE CLIENTE
                        SET
                            NOME = @NOME,
                            CPF = @Cpf,
                            EMAIL = @Email,
                            DATANASCIMENTO = @DataNascimento
                        WHERE
                            ID = @Id
                ";

            using (var connection = new SqlConnection(SqlServerSettings.GetConnectionString()))
            {
                connection.Execute(query, new
                {
                    @Nome = cliente.Nome,
                    @Cpf = cliente.Cpf,
                    @Email = cliente.Email,
                    @DataNascimento = cliente.DataNascimento
                });
            }
        }
    }
}
