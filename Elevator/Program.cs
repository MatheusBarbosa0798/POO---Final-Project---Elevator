using System;
using System.Diagnostics;

namespace Elevator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int TotalFloors = 10;
            int TotalCapacity = 15;
            int Option;

            ElavatorModel elevatorModel = new ElavatorModel(TotalCapacity, TotalFloors); //Construtor

            while (true)
            {
                Options();
                Option = Int32.Parse(Console.ReadLine());
                switch (Option)
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

        public static void Options()
        {
            Console.WriteLine("Aperte:\n");
            Console.WriteLine("0 - Entrar\n");
            Console.WriteLine("1 - Sair\n");
            Console.WriteLine("2 - Subir\n");
            Console.WriteLine("3 - Descer\n");
        }
    }
}