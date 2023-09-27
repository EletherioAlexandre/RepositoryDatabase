using CSharpProjeto01.Controllers;

namespace CSharpProjeto01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n*** Controle de Clientes ***\n");
            Console.WriteLine("[1] - Cadastrar cliente \n[2] - Atualizar cliente \n[3] - Excluir cliente \n[4] - Consultar todos os clientes");

            Console.Write("\nInforme a opçao desejada: ");
            var opcao = int.Parse(Console.ReadLine());
            var clienteController = new ClienteController();

            switch (opcao)
            {
                case 1:
                    clienteController.CadastrarCliente();
                    break;
                case 2:
                    clienteController.AtualizarCliente();
                    break;
                case 3:
                    clienteController.ExcluirCliente();
                    break;
                case 4:
                    clienteController.ConsultarClientes();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nDeseja continuar? (S/N)");
            var continuar = Console.ReadLine();

            if (continuar.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Fim do programa.");
                Console.ReadKey();
            }
        }
    }
}