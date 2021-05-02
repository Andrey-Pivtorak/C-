using System;

namespace WashingMashine
{
    public class ShowMessages
    {
        private string _nameProgram { get; set; }
        private int _time { get; set; }
        private int _temperature { get; set; }
        private int _numbRinses { get; set; }
        private int _spinning { get; set; }
        private string _ecobuble { get; set; }
        
        public ShowMessages(string nameProgram, int time, int temperature, int numbRinses, int spinning, string ecobuble)
        {
            _nameProgram = nameProgram;
            _time = time;
            _temperature = temperature;
            _numbRinses = numbRinses;
            _spinning = spinning;
            _ecobuble = ecobuble;
        }

        /// <summary>
        /// Метод выводит на экран приветствие.
        /// </summary>
        public static void ShowWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t ================================================");
            Console.WriteLine("\t\t\t\t Тебя приветствует современная стиральная машина!");
            Console.WriteLine("\t\t\t\t ================================================");
            Console.WriteLine();
            Console.ResetColor();
        }

        /// <summary>
        /// Метод выводит на экран список программ для стирки.
        /// </summary>        
        public static void ListOfPrograms()
        {
            Console.WriteLine("Выбери режим стирки (введи цифру):");
            Console.WriteLine();
            Console.WriteLine("1. Ежедневная");
            Console.WriteLine("2. Хлопок");
            Console.WriteLine("3. Синтетика");
            Console.WriteLine("4. Джинсы");
            Console.WriteLine("5. Постельное белье");
            Console.WriteLine("6. Темные вещи");
            Console.WriteLine("7. Детские вещи");
            Console.WriteLine("8. Верхняя одежда");
            Console.WriteLine("9. Полоскание + отжим");
            Console.WriteLine("10. Отжим");            
        }

        /// <summary>
        /// Метод выводит на экран параметры выбранной программы.
        /// </summary>
        public void ShowProgramValues()
        {            
            Console.WriteLine(" Режим стирки: " + _nameProgram);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ========================================================================");
            Console.WriteLine("| Время стирки\t  t воды(град.)\t  Полосканий\tОтжим(оборотов)\tEcobuble |");
            Console.WriteLine(" ========================================================================");
            Console.ResetColor();
            Console.WriteLine($"{TimeSpan.FromMinutes(_time).Hours} час. {TimeSpan.FromMinutes(_time).Minutes} мин." +
                                $" \t\t{_temperature}\t\t{_numbRinses}\t   {_spinning}\t\t {_ecobuble}");
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выводит на экран варианты для изменения выбранной программы.
        /// </summary>
        public static void ShowProgramChanges()
        {            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Если хочешь изменить программу, введи необходимую цифру");
            Console.ResetColor();
            Console.WriteLine("Ты можешь изменить:");
            Console.WriteLine("1. Температуру");
            Console.WriteLine("2. Полоскание");
            Console.WriteLine("3. Отжим");
            Console.WriteLine("4. Екобабл");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. --> Перейти назад к выбору программы");
            Console.ResetColor();
            Console.WriteLine("0. Ничего не менять");            
        }

        /// <summary>
        /// Метод выводит на экран варианты для изменения программы "Полоскание + Отжим".
        /// </summary>
        public static void ShowRinsePlusSpinCanges()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Если хочешь изменить программу, введи необходимую цифру");
            Console.ResetColor();
            Console.WriteLine("Ты можешь изменить:");
            Console.WriteLine("1. Полоскание");
            Console.WriteLine("2. Отжим");
            Console.WriteLine("0. Ничего не менять");            
        }

        /// <summary>
        /// Метод выводит на экран варианты для изменения программы "Отжим".
        /// </summary>
        public static void ShowSpinningChange()
        {            
            Console.WriteLine("0. Ничего не менять");                                              
        }

        /// <summary>
        /// Метод выводит на экран значения температуры стирки для изменения.
        /// </summary>
        public static void ShowTemperatureChanges()
        {            
            Console.WriteLine("Выбери пункт для установки температури (градусов):");
            Console.WriteLine("1. 0");
            Console.WriteLine("2. 30");
            Console.WriteLine("3. 40");
            Console.WriteLine("4. 60");
            Console.WriteLine("5. 95");            
        }

        /// <summary>
        /// Метод выводит на экран количество полосканий для изменения.
        /// </summary>
        public static void ShowRinseChanges()
        {            
            Console.WriteLine("Выбери количество полосканий:");
            Console.WriteLine("1 полоскание");
            Console.WriteLine("2 полоскания");
            Console.WriteLine("3 полоскания");            
        }

        /// <summary>
        /// Метод выводит на экран количество оборотов отжима для изменения.
        /// </summary>
        public static void ShowSpinningChanges()
        {            
            Console.WriteLine("Выбери пункт для установки оборотов при отжиме:");
            Console.WriteLine("1. 0");
            Console.WriteLine("2. 400");
            Console.WriteLine("3. 600");
            Console.WriteLine("4. 800");
            Console.WriteLine("5. 1000");
            Console.WriteLine("6. 1200");            
        }

        /// <summary>
        /// Метод выводит на экран режим Ecobuble для изменения.
        /// </summary>
        public static void ShowEcobubleChanges()
        {            
            Console.WriteLine("Включить или выключить Ecobuble:");
            Console.WriteLine("1. Включить");
            Console.WriteLine("2. Выключить");                        
        }
        
        /// <summary>
        /// Метод оповещает, что программа далее идет с изменениями.
        /// </summary>
        public static void ShowMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Программа с изменениями:");
            Console.ResetColor();
        }
    }
}
