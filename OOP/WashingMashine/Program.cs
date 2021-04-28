using System;

namespace WashingMashine
{
    class Program
    {        
        static void Main(string[] args)
        {            
            // вывод приветствия
            ShowMessages.ShowWelcome();

            // проверка перед началом стирки
            ChekInput.TurnOnWashingMashine();
            ChekInput.AddPowder();
            ChekInput.CloseTray();
            ChekInput.CloseDoor();
            Console.Clear();

            // вывод сообщения со списком програм
            ShowMessages.ListOfPrograms();

            // ввод номера программы пользователем (с проверкой)
            SetValues.SelectionConditionsProgram();

            /* 
             * Программа имитирует функции стиральной машины.
             * В процессе использования можно выбирать различные режимы стирки, а также их изменять.
             * Ввод пользователем с клавиатуры проверяется на корректность.
             * Время стирки изменяется в зависимости от установленных параметров пользователем.
             */
            Console.ReadKey();
        }
    }
}
