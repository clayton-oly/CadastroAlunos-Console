using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunos_Console.Controller;

namespace CadastroAlunos_Console.Views
{
    public class AlunoView
    {
        private AlunoController controller = new();

        public void MostrarMenu()
        {
            int opcao;

            do
            {
                Console.WriteLine("=== Cadastro do Aluno do SENAC ===");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Listar Alunos");
                Console.WriteLine("3 - Atualizar Alunos");
                Console.WriteLine("4 - Excluir Alunos");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                { 
                    case 1: CadastrarAlunos();
                        break;

                    case 2: ListarAlunos();
                        break;

                    case 3: AtualizarAlunos();
                        break;

                    case 4: ExcluirAlunos();
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();

            } while (opcao != 0);
        }

        private void CadastrarAlunos()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: (dd/mm/aaaa)");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            controller.CadastrarAluno(nome, cpf, curso, dataNascimento);
            Console.WriteLine("Aluno cadastrado com sucesso");
        }

        private void ListarAlunos()
        {
        }

        private void AtualizarAlunos()
        {
        }

        private void ExcluirAlunos()
        {
        }
    }
}
