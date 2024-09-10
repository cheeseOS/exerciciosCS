using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome, usuário?");
            string user = Console.ReadLine();
            Console.WriteLine("Bem vindo à Calculadora, " + user + ".");
            while (true)
            {
                Console.WriteLine(user + ", qual é o primeiro número desejado para a sua operação?");
                float num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número desejado para a sua operação?");
                float num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("E qual é a operação desejada? Por favor, use: +, -, /, * ");
                string op = Console.ReadLine();
                if (op == "+" || op == "soma")
                {
                    float re = num1 + num2;
                    Console.WriteLine("O resultado é " + re);
                }
                else if (op == "-" || op == "subtração")
                {
                    float re = num1 - num2;
                    Console.WriteLine("O resultado é " + re);
                }
                else if (op == "*" || op == "multiplicação")
                {
                    float re = num1 * num2;
                    Console.WriteLine("O resultado é " + re);
                }
                else if (op == "/" || op == "divisão")
                {
                    float re = num1 / num2;
                    Console.WriteLine("O resultado é " + re);
                }
                else
                {
                    Console.WriteLine("A operação desejada é invalida");
                }
                Console.WriteLine("Deseja realizar outra operação? sim ou nao");
                string cont = Console.ReadLine();
                if (cont == "sim" || cont == "s")
                {
                    continue;
                }
                else if (cont == "nao" || cont == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma resposta válida");
                }
            }
        }
    }
}
