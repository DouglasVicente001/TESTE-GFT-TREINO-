using static System.Console;
namespace ULIMOTESTE.Models
{
    public interface IAluno
    {
         public string Nome { get; set; }
         public string Matricula { get; set; }
         public string Escola{ get; set; }
         public string Universidade { get; set; }
         

         public void AlunoInfo();
         public string Mensagem();

    }
}