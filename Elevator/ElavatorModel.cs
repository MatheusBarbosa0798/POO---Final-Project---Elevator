using System;

namespace Elevator
{
    public class ElavatorModel
    {
        private const int GroundFloor = 0;
        
        //gets e sets
        private int TotalFloors { get; set; }
        private int CurrentFloor { get; set; }
        private int TotalCapacity { get; set; }
        private int CurrentCapacity { get; set; }

        public ElavatorModel(int totalCapacity, int totalFloors) //construtor recebendo a capacidade total do elevador e total de andares do prédio
        {
            CurrentFloor = 0;
            CurrentCapacity = 0;
            TotalCapacity = totalCapacity;
            TotalFloors = totalFloors;
        }

        public void Enter() //método "entra"
        {
            if (CurrentCapacity < TotalCapacity)
            {
                CurrentCapacity++;
                Console.WriteLine("Entrou!\n" + CurrentCapacity + " pessoas no elevador."); //Console.WriteLine escreve no console
            }
            else
            {
                Console.WriteLine("O elevador está cheio!");
            }
        }

        public void Exit() //método "sai"
        {
            if (CurrentCapacity > 0)
            {
                CurrentCapacity--;
                Console.WriteLine("Saiu!\n" + CurrentCapacity + " pessoas no elevador.");
            }
            else
            {
                Console.WriteLine("O elevador já está vazio!");
            }
        }

        public void Up() //método "sobe"
        {
            if (CurrentFloor < TotalFloors)
            {
                CurrentFloor++;
                Console.WriteLine("Subindo!\n" + CurrentFloor + "° Andar");
            }
            else
            {
                Console.WriteLine("Você já está no último andar!");
            }
        }

        public void Down() //método "desce"
        {
            if (CurrentFloor > 0)
            {
                CurrentFloor--;
                if (CurrentFloor == ElavatorModel.GroundFloor) 
                {
                    Console.WriteLine("Descendo!\nTérreo"); //printa uma mensagem avisando que está descendo ao térreo
                }
                else
                {
                    Console.WriteLine("Descendo!\n" + CurrentFloor + "° Andar"); //printa uma mensagem avisando que está descendo para algum andar que não é o térreo
                }
            }
            else
            {
                Console.WriteLine("Você já está no térreo!");
            }
        }
    }
}