using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunos_Console.Models;

namespace CadastroAlunos_Console.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos = new ();
        private int proximoId = 1;

        public void CadastrarAluno(string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno novoAluno = new (proximoId++, nome, cpf, curso, dataNascimento);
            alunos.Add (novoAluno);
        }

        public void ListarAlunos() 
        { 
        }
        public void AtualizarAlunos()
        {
        }
        public void ExcluirAlunos()
        {
        }
    }
}
