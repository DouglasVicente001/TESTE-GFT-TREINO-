using static System.Console;
namespace ULIMOTESTE.Models
{
      public class AlunoFundamental : IAluno
      {
            public string Nome { get ;set;}
            public string Matricula { get ;set;}
            public string Escola { get ;set;}
            public string Universidade { get ;set;}

            public void AlunoInfo()
            {
                    WriteLine("Informe o nome do aluno: ");
                    Nome = ReadLine();
                    WriteLine("Informe a matricula: ");
                    Matricula = ReadLine();
            }
            public string Mensagem()
            {
                return "=== INFORMAÇÕES DO ALUNO ==="+$"\nNome : {Nome}" + $"\nMatricula: {Matricula}";
            }
      }
}