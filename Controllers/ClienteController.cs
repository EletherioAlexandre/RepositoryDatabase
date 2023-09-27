using CSharpProjeto01.Entities;
using CSharpProjeto01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpProjeto01.Controllers
{
    public class ClienteController
    {
        public void CadastrarCliente()
        {
            try
            {
                Console.WriteLine("\n*** Cadastrar Cliente ***");
                var cliente = new Cliente();
                cliente.Id = Guid.NewGuid();

                Console.Write("Nome..........: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("CPF..........: ");
                cliente.Cpf = Console.ReadLine();

                Console.Write("Email..........: ");
                cliente.Email = Console.ReadLine();

                Console.Write("Data de Nascimento..........: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                var clienteRepository = new ClienteRepository();

                clienteRepository.InsertClient(cliente);
                Console.WriteLine("Cliente cadastrado com sucesso!");
                Console.ReadKey();


            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }

        public void AtualizarCliente()
        {
            try
            {
                Console.WriteLine("\n*** Edição de Clientes: ***\n");
                Console.Write("Informe o ID do cliente..........: ");
                var id = Guid.Parse(Console.ReadLine());

                var clienteRepository = new ClienteRepository();
                var cliente = clienteRepository.GetById(id);

                if (cliente != null)
                {
                    Console.Write("Nome..........: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("CPF..........: ");
                    cliente.Cpf = Console.ReadLine();

                    Console.Write("Email..........: ");
                    cliente.Email = Console.ReadLine();

                    Console.Write("Data de Nascimento..........: ");
                    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                    clienteRepository.UpdateClient(cliente);
                    Console.WriteLine("Cliente atualizado com sucesso!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nNenhum cliente foi encontrado com o ID informado.");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }

        public void ExcluirCliente()
        {
            try
            {
                Console.WriteLine("\n*** Exclusão de Clientes: ***\n");
                Console.Write("Informe o ID do cliente..........: ");
                var id = Guid.Parse(Console.ReadLine());

                var clienteRepository = new ClienteRepository();
                var cliente = clienteRepository.GetById(id);

                if (cliente != null)
                {
                    clienteRepository.DeleteClient(cliente);
                    Console.WriteLine("Cliente excluído com sucesso!.");
                }
                else
                {
                    Console.WriteLine("\nNenhum cliente foi encontrado com o ID informado.");
                }
            }
            catch (Exception error)
            {

                Console.WriteLine($"Error: {error.Message}");
            }
        }

        public void ConsultarClientes()
        {
            try
            {
                Console.WriteLine("\n Consultar todos os clientes");
                var clienteRepository = new ClienteRepository();
                var clientes = clienteRepository.GetAll();

                if (clientes.Count > 0)
                {
                    foreach (var cliente in clientes)
                    {
                        Console.WriteLine($"Id.........: {cliente.Id}");
                        Console.WriteLine($"Nome.........: {cliente.Nome}");
                        Console.WriteLine($"CPF.........: {cliente.Cpf}");
                        Console.WriteLine($"Email.........: {cliente.Email}");
                        Console.WriteLine($"Data de Nascimento.........: {cliente.DataNascimento.ToString("dd/MM/yyyy")}");
                        Console.WriteLine("...");
                    }
                } else
                {
                    Console.WriteLine("Não há clientes cadastrados no banco de dados.");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }

        }
    }
}
