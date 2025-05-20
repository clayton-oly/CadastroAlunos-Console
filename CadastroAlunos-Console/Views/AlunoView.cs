using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunos_Console.Controller;
using CadastroAlunos_Console.Models;

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
                Console.WriteLine("3 - Atualizar Aluno");
                Console.WriteLine("4 - Excluir Aluno");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                { 
                    case 1: CadastrarAluno();
                        break;

                    case 2: ListarAlunos();
                        break;

                    case 3: AtualizarAluno();
                        break;

                    case 4: ExcluirAluno();
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();

            } while (opcao != 0);
        }

        private void CadastrarAluno()
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
            List<Aluno> alunos = controller.ListarAlunos();
            Console.WriteLine("\nLista de alunos: ");
            foreach (var aluno in alunos)
            {
                { Console.WriteLine($"ID: {aluno.Id} | Nome: {aluno.Nome} | CPF: {aluno.CPF} | Curso: {aluno.Curso} | Data de Nascimento: {aluno.DataNascimento}");}
            }
        }

        private void AtualizarAluno()
        {
            Console.WriteLine("Digite o ID do aluno a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Novo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Novo CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Novo curso ");
            string curso = Console.ReadLine();
            Console.WriteLine("Nova data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            bool atualizado = controller.AtualizarAluno(id, nome, cpf, curso, dataNascimento);
            Console.WriteLine(atualizado? "Aluno atualizado com sucesso" : "Aluno não encontrado");
        }

        private void ExcluirAluno()
        {
            Console.WriteLine("Digite o ID do aluno a ser excluido: ");
            int id = int.Parse(Console.ReadLine());
            bool excluido = controller.ExcluirAluno(id);
            Console.WriteLine(excluido? "Aluno excluido com sucesso" : "Aluno não excluido");
        }
    }
}
