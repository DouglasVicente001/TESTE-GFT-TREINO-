using ULIMOTESTE.Models;
using static System.Console;
namespace ULTIMOTESTE
{
      class program
      {
            public static void Main(string[]args)
            {
                  WriteLine("Escolha uma das opções a seguir: "+
                  "\n[1] Para inserir aluno fundamental: "+
                  "\n[2] Para inserir aluno medio: "+
                  "\n[3] Para inserir aluno superior: ");
                  string Opcao =ReadLine();
                  
                  switch(Opcao)
                  {
                        case "1":
                        AlunoFundamental Aluno = new AlunoFundamental();

                        Aluno.AlunoInfo();
                        WriteLine(Aluno.Mensagem());
                        break;

                        case "2":
                        AlunoMedio Aluno2= new AlunoMedio();

                        Aluno2.AlunoInfo();
                        WriteLine(Aluno2.Mensagem());
                        break;
                        
                        case "3":
                        AlunoSuperior Aluno3= new AlunoSuperior();

                        Aluno3.AlunoInfo();
                        WriteLine(Aluno3.Mensagem());
                        break;

                        default:
                        WriteLine("Informe uma opção válida!, saindo do app...");
                        break;
                  }
            }
      }
}