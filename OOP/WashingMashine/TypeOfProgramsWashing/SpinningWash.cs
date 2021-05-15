using System;
using System.Linq;

namespace WashingMashine
{
    public class ChekInput
    {
        private int[] _array { get; set; }
        
        public ChekInput(int[] array)
        {
            _array = array;
        }

        /// <summary>
        /// Метод проверяет, включена ли машинка в розетку.
        /// </summary>
        /// <returns> Возвращают True или False. </returns>
        public static bool TurnOnWashingMashine()
        {
            while (true)
            {
                Console.Write("Ты включил машинку в розетку? (Да / Нет) ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string answer = Console.ReadLine();
                Console.ResetColor();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Чтобы постирать, включи машинку в розетку и нажми кнопку \"Вкл.\" ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }                
            }
        }

        /// <summary>
        /// Метод проверяет, добавлен ли порошок.
        /// </summary>
        /// <returns> Возвращают True или False. </returns>
        public static bool AddPowder()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты добавил порошок? (Да / Нет) ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string answer = Console.ReadLine();
                Console.ResetColor();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Без порошка не постираешь!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Метод проверяет, закрыт ли лоток с порошком.
        /// </summary>
        /// <returns> Возвращают True или False. </returns>
        public static bool CloseTray()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты закрыл лоток с порошком? (Да / Нет) ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string answer = Console.ReadLine();
                Console.ResetColor();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("При открытом лотке использование порошка невозможно!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Метод проверяет, закрыта ли дверца стиральной машины.
        /// </summary>
        /// <returns> Возвращают True или False. </returns>
        public static bool CloseDoor()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ты закрыл дверцу стиральной машины? (Да / Нет) ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string answer = Console.ReadLine();
                Console.ResetColor();

                if (answer == "Да" || answer == "да")
                {
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Машинка не стирает с открытой дверцой. Закрой ее!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Метод проверяет корректность ввода данных пользователем.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public int CheckUserInput()
        {
            while (true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;                
                string input = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine();

                bool result = int.TryParse(input, out int selection);
                if (result == true)
                {
                    int inputParse = int.Parse(input);

                    if (_array.Any(i => i == inputParse))
                    {
                        return inputParse;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нужно вибрать цифру из списка!");
                        Console.ResetColor();
                    }                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вводить нужно только цифру из списка!");
                    Console.ResetColor();
                }                                
            }            
        }

        /// <summary>
        /// Метод проверяет корректность ввода дополнительных изменений.
        /// </summary>
        /// <returns> Возвращает Да или Нет. </returns>
        public static bool CheckChanges()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Изменения сохранены. Что-то еще хочешь изменить? (Да / Нет)");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;                
                string answer = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine();

                if (answer == "Да" || answer == "да")
                {                    
                    return true;
                }
                else if (answer == "Нет" || answer == "нет")
                {                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Стирка началась...");
                    Console.ResetColor();
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }
            }
        }
    }
}
