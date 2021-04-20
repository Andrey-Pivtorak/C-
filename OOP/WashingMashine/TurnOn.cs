// check before the washing

using System;

namespace WashingMashine
{
    class TurnOn
    {
        public static bool PreparationWashMach()
        {                   
            while (true)
            {
                Console.Write("Ты включил в розетку? (Да / Нет) ");
                string answer = Console.ReadLine();

                if (answer == "Да" || answer == "да" )
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.WriteLine("Чтобы постирать, включи в розетку и нажми кнопку \"Вкл.\" ");                    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }

        public static bool AddPowder()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты добавил порошок? (Да / Нет) ");
                string answer = Console.ReadLine();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.WriteLine("Без порошка не посстираешь!");                    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }

        public static bool CloseTray()
        {            
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты закрыл лоток с порошком? (Да / Нет) ");
                string answer = Console.ReadLine();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.WriteLine("При открытом лотке использование порошка невозможно!");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }            
        }

        public static bool CloseDoor()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты закрыл дверцу стиральной машины? (Да / Нет) ");
                string answer = Console.ReadLine();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.WriteLine("Машинка не стирает с открытой дверцой. Закрой ее!");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
        }
    }
}
