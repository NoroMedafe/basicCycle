using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRepetitions;
            string userName;

            Console.Write("Выведем ваще имя столько раз сколько захотите!" + "\n" + "Введите имя: ");
            userName = Console.ReadLine();
            Console.Write("Сколько раз вывести?: "); numberOfRepetitions= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.Write(userName + " ");
            }
            Console.WriteLine("Всё!");
            Console.ReadKey();
        }
    }
}
