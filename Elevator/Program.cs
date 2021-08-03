using System;
using System.Diagnostics;
//"using" é o "import" do C#

namespace Elevator
{
    internal class Program
    {
        public static void Main(string[] args) //método main
        {
            //variáveis sendo criadas para deixar o código mais limpo
            int TotalFloors = 10;
            int TotalCapacity = 15;
            int Option;

            ElavatorModel elevatorModel = new ElavatorModel(TotalCapacity, TotalFloors); //Construtor sendo chamado

            while (true) //enquanto o processo estiver rodando...
            {
                Options(); //chamo o método options, criado mais a frente no código, que mostra as opções ao usuário
               
                Option = Int32.Parse(Console.ReadLine()); //Console.ReadLine() lé a entrada, como um Scanf mas bem mais simples, porém ele só le string,
                                                          //por isso uso um parse para converter a imput em formato string que o usuario vai digitar
                                                          //e armazeno na minha variável como inteiro
                
                switch (Option) //um switch case assim como no java, para ler a input do usuário e chamar os métodos criados na classe ElevatorModel
                {
                    case 0:
                        elevatorModel.Enter();
                        break;
                    case 1:
                        elevatorModel.Exit();
                        break;
                    case 2:
                        elevatorModel.Up();
                        break;
                    case 3:
                        elevatorModel.Down();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public static void Options() //método que mostra as opções ao usuário
        {
            Console.WriteLine("Aperte:\n");
            Console.WriteLine("0 - Entrar\n");
            Console.WriteLine("1 - Sair\n");
            Console.WriteLine("2 - Subir\n");
            Console.WriteLine("3 - Descer\n");
        }
    }
}