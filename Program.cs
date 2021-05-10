using System;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Funcionario>();


            Console.Write("Olá, deseja cadastrar quantos funcionarios? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= n; i++) //Adcionando valores a lista<funcionarios>
            {
                Console.WriteLine("Funcionario #"+i);

                Console.Write("Digite o id :");
                int id = int.Parse(Console.ReadLine());
               
                
                Console.Write("Digite o nome :");
                string nome = Console.ReadLine();   
                
                Console.Write("Digite o salario :");
                double salario = double.Parse(Console.ReadLine()); 
            
                list.Add(new Funcionario (id,nome,salario));

            }

            Console.WriteLine("Digite o Id do funcionario que você deseja aumentar o salario :");
            int IdAumento = int.Parse(Console.ReadLine());

            var teste = list.Find(x => x.Id == IdAumento); //Buscando funcionario com o ID digitado
            if (teste != null) //Caso teste seja igual a nulo quer dizer que o ID digitado não foi encontrado.
            {
                Console.WriteLine("Qual valor deseja aumentar? :");
                int SalarioAumento = int.Parse(Console.ReadLine());
                teste.Percentual(SalarioAumento);
            }
            else
            {
                Console.WriteLine("Id não encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Segue abaixo lista de funcionarios :");
            foreach (var func in list)  // foreash passando todos os funcionarios na tela.
            {
                Console.WriteLine(func);
            }

        }
    }
}
