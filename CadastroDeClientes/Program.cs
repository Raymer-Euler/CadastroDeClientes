using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestãoClientes
{
    internal class Program
    {
        struct Clientes  // estrutura dos dados do cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Clientes> listaClientes = new List<Clientes>(); // lista de clientes
        static Clientes novoCliente = new Clientes();
        static void Main(string[] args)
        {
            int escolha;
            do
            {
                Console.WriteLine("Cadastro de clientes:");
                Console.WriteLine("1-Adicionar\n2-Exibir listagem\n3-Excluir\n4-Sair");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        Excluir();
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa..\naperte ENTER para sair");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (escolha != 4);
        }
        static void Adicionar()
        {


            Console.WriteLine("Nome:");
            novoCliente.nome = Console.ReadLine();
            Console.WriteLine("Email:");
            novoCliente.email = Console.ReadLine();
            Console.WriteLine("CPF:");
            novoCliente.cpf = Console.ReadLine();
            Console.WriteLine("Cliente Cadastrado!\nAperte ENTER para continuar");
            Console.ReadLine();
            listaClientes.Add(novoCliente); // adiciona novo cliente para a lista de clientes
            Console.Clear();
            Console.WriteLine("Adicionar outro cliente:\n1-Sim\n2-Não");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opcao == 1)
            {
                Adicionar();
            }
            else if (opcao == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Escolha uma opção valida!");
                Console.ReadLine();
            }

        }
        static void Listar()
        {
            if (listaClientes == null || listaClientes.Count == 0)
            {
                Console.WriteLine("LISTA VAZIA");

            }
            else
            {
                Console.WriteLine("Listagem de clientes:");
                Console.WriteLine("_____________________");
                for (int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine($"ID:{i + 1}");
                    Console.WriteLine($"Nome: {listaClientes[i].nome}");
                    Console.WriteLine($"Email: {listaClientes[i].email}");
                    Console.WriteLine($"CPF: {listaClientes[i].cpf}");
                    Console.WriteLine("=================");

                }
            }
            Console.WriteLine("Aperte ENTER para voltar");
            Console.ReadLine();
        }
        static void Excluir()
        {
            if (listaClientes == null || listaClientes.Count == 0)
            {
                Console.WriteLine("Não há clientes para excluir!");
            }
            else
            {
                Console.WriteLine("Excluir dados\nNome:");
                string nome = Console.ReadLine();
                listaClientes.RemoveAll(frase => frase.nome == nome); //excluir todo o contato pelo Nome.
                Console.WriteLine($"Dados de {nome} apagados");
            }
            Console.ReadLine();


        }
    }
}
