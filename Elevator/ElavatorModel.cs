using System;

namespace Elevator
{
    public class ElavatorModel
    {
        private const int GroundFloor = 0;

        private int TotalFloors { get; set; }
        private int CurrentFloor { get; set; }
        private int TotalCapacity { get; set; }
        private int CurrentCapacity { get; set; }

        public ElavatorModel(int totalCapacity, int totalFloors)
        {
            CurrentFloor = 0;
            CurrentCapacity = 0;
            TotalCapacity = totalCapacity;
            TotalFloors = totalFloors;
        }

        public void Enter()
        {
            if (CurrentCapacity < TotalCapacity)
            {
                CurrentCapacity++;
                Console.WriteLine("Entrou!\n" + CurrentCapacity + " pessoas no elevador.");
            }
            else
            {
                Console.WriteLine("O elevador está cheio!");
            }
        }

        public void Exit()
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

        public void Up()
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

        public void Down()
        {
            if (CurrentFloor > 0)
            {
                CurrentFloor--;
                if (CurrentFloor == ElavatorModel.GroundFloor)
                {
                    Console.WriteLine("Descendo!\nTérreo");
                }
                else
                {
                    Console.WriteLine("Descendo!\n" + CurrentFloor + "° Andar");
                }
            }
            else
            {
                Console.WriteLine("Você já está no térreo!");
            }
        }
    }
}