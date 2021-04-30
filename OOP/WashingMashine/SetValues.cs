using WashingMashine.TypeOfProgramsWashing;

namespace WashingMashine
{
    public class SetValues
    {
        private string NameProgram { get; set; }
        private int NumbRinses { get; set; }
        private int Spinning { get; set; }
                
        public SetValues(string nameProgram, int numbRinses, int spinning)
        {
            NameProgram = nameProgram;
            NumbRinses = numbRinses;
            Spinning = spinning;
        }

        /// <summary>
        /// Метод формирует условия выбора программы.
        /// </summary>
        public static void SelectionConditionsProgram()
        {
            int selection = ListOfPrograms();

            switch (selection)
            {
                case 1:
                    DailyWash dailyWash = new();
                    dailyWash.SetProgram();
                    dailyWash.SetOfProgramChanges();                    
                    break;

                case 2:
                    CottonWash cotton = new();
                    cotton.SetProgram();
                    cotton.SetOfProgramChanges();
                    break;

                case 3:
                    SyntheticWash synthetic = new();
                    synthetic.SetProgram();
                    synthetic.SetOfProgramChanges();
                    break;

                case 4:
                    JeansWash jeans = new();
                    jeans.SetProgram();
                    jeans.SetOfProgramChanges();
                    break;

                case 5:
                    LinensWash linens = new();
                    linens.SetProgram();
                    linens.SetOfProgramChanges();
                    break;

                case 6:
                    DarkThingsWash darkThings = new();
                    darkThings.SetProgram();
                    darkThings.SetOfProgramChanges();
                    break;

                case 7:
                    KidsThingsWash kidsThings = new();
                    kidsThings.SetProgram();
                    kidsThings.SetOfProgramChanges();
                    break;

                case 8:
                    OutWearWash outWear = new();
                    outWear.SetProgram();
                    outWear.SetOfProgramChanges();
                    break;

                case 9:
                    RinsePlusSpinWash rinsePlusSpin = new();
                    rinsePlusSpin.SetProgram();
                    rinsePlusSpin.SetOfProgramChanges();
                    break;

                case 10:
                    SpinningWash spinningWash = new(); ;
                    spinningWash.SetProgram();
                    spinningWash.SetOfProgramChanges();
                    break;
            }
        }       

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе программы. 
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static  int ListOfPrograms()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();
            
            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем для программы "Полоскание + Отжим". 
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfRinsePlusSpinWash()
        {
            int[] array = { 0, 1, 2 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем для программы "Отжим". 
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfSpinningWash()
        {
            int[] array = { 0 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе изменений программы.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfChanges()
        {
            int[] array = { 0, 1, 2, 3, 4, 5 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе значения температуры.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfTemperatureChanges()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе изменения количества полосканий.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfRinseChanges()
        {
            int[] array = { 1, 2, 3 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе изменения количества оборотов отжима.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfSpinningChanges()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод проверяет правильность ввода данных пользователем при выборе значения Ecobubble.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public static int ListOfEcobubleChanges()
        {
            int[] array = { 1, 2 };
            ChekInput check = new(array);
            int selection = check.CheckUserInput();

            return selection;
        }

        /// <summary>
        /// Метод устанавливает время стирки.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public int SetWashTime()
        {
            int time = 0;
            if (NumbRinses == 0 && (Spinning == 400 || Spinning == 600 || Spinning == 800 || Spinning == 1000 || Spinning == 1200))
                time += 9;
            else if (NumbRinses == 1 && Spinning == 0)
                time += 15;
            else if (NumbRinses == 1 && (Spinning == 400 || Spinning == 600))
                time += 45;
            else if (NumbRinses == 1 && (Spinning == 800 || Spinning == 1000 || Spinning == 1200))
                time += 55;

            else if (NumbRinses == 2 && Spinning == 0)
                time += 20;
            else if (NumbRinses == 2 && (Spinning == 400 || Spinning == 600))
                time += 50;
            else if (NumbRinses == 2 && (Spinning == 800 || Spinning == 1000 || Spinning == 1200))
                time += 60;

            else if (NumbRinses == 3 && Spinning == 0)
                time += 25;
            else if (NumbRinses == 3 && (Spinning == 400 || Spinning == 600))
                time += 65;
            else if (NumbRinses == 3 && (Spinning == 800 || Spinning == 1000 || Spinning == 1200))
                time += 75;

            return time;
        }

        /// <summary>
        /// Метод устанавливает окончательное время стирки, учитывая вибранную программу.
        /// </summary>
        /// <returns> Возвращает целое число. </returns>
        public int SetWashTimeFinish()
        {
            int time = SetWashTime();

            if (NameProgram == "Ежедневная стирка")
                time += 10;
            else if (NameProgram == "Темные вещи" || NameProgram == "Джинсы")
                time += 20;
            else if (NameProgram == "Детские вещи" || NameProgram == "Верхняя одежда")
                time += 30;
            else if (NameProgram == "Постельное белье" || NameProgram == "Синтетика")
                time += 15;

            return time;
        }
    }
}   
