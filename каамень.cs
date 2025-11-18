using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра камень-ножницы-бумага");
            Console.WriteLine("Выбери 1-Камень,2-ножницы,3-бумага.Твой ход:");
            string player = Console.ReadLine();
            if (player != "1" && player != "2" && player != "3")
            {
                Console.WriteLine("Неправильный ввод");
                return;
            }
            int choise = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int Computer = random.Next(1, 4);
            Console.WriteLine("компьютер выбрал:" + Computer);
            string result = GetResult(choise, Computer);
            Console.WriteLine(result);
            Console.WriteLine("Игра окончена");
        }
        static string GetResult(int choise, int Computer)
        {
            if (choise == Computer)
            {
                return "Ничья";
            }
            if (choise == 1 && Computer == 2)
            {
                return "Ты выйграл! Камень ломает ножницы";
            }
            if (choise == 2 && Computer == 3)
            {
                return "Ты выйграл! Ножницы режут бумагу";
            }
            if (choise == 3 && Computer == 1)
            {
                return "Ты выйграл! Бумага заворачивает камень";
            }
            return "компьютер выйграл!";
        }
        static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("Хотите сыграть еще раз? (да/нет): ");
                string input = Console.ReadLine()?.ToLower(); // Считываем ввод и переводим в нижний регистр

                if (input == "да")
                {
                    return true; // Играем еще раз
                }
                else if (input == "нет")
                {
                    return false; // Завершаем игру
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите 'да' или 'нет'.");
                }
            }
        }
    }
}
