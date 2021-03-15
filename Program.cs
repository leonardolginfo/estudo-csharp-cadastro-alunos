using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine();

            while(opcaoUsuario.ToUpper() !="x")
            {
                switch(opcaoUsuario)
                
                {
                    case ("1"):
                        //todo: Add aluno
                    break;
                    
                    case ("2"):
                        //todo: Listar aluno
                    break;

                    case ("3"):
                        //todo: Calcular media geral
                    break;
                    
                    default:

                    throw new ArgumentOutOfRangeException();

                }

            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();


            }
        }
    }
}
