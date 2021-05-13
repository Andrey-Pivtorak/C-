using System;

namespace WashingMashine.TypeOfProgramsWashing
{
    public class PatternProgramsWashing : ISetProgram
    {
        private string _nameProgram { get; set; }
        protected int _time { get; set; }
        protected int _temperature { get; set; }
        protected int _numbRinses { get; set; }
        protected int _spinning { get; set; }
        protected string _ecobuble { get; set; }
        
        public PatternProgramsWashing(string nameProgram, int temperature, int numbRinses, int spinning, string ecobuble)
        {
            _nameProgram = nameProgram;            
            _temperature = temperature;
            _numbRinses = numbRinses;
            _spinning = spinning;
            _ecobuble = ecobuble;
        }
        
        /// <summary>
        /// Метод выводит на экран значения выбранной программы пользователем.
        /// </summary>
        public void SetProgram()
        {
            SetValues washTime = new(_nameProgram, _numbRinses, _spinning);
            _time = washTime.SetWashTimeFinish();            
            ShowMessages set = new(_nameProgram, _time, _temperature, _numbRinses, _spinning, _ecobuble);
            set.ShowProgramValues();
        }

        /// <summary>
        /// Метод предлагает сделать изменения выбранной программы.
        /// </summary>
        public virtual void SetOfProgramChanges()
        {
            ShowMessages.ShowProgramChanges();
            int selectionChanges = SetValues.ListOfChanges();

            switch (selectionChanges)
            {
                case 1:
                    ShowMessages.ShowTemperatureChanges();
                    int selectionTemp = SetValues.ListOfTemperatureChanges();

                    switch (selectionTemp)
                    {
                        case 1:
                            _temperature = 0;                           
                            MoreChanges();                            
                            break;

                        case 2:
                            _temperature = 30;                            
                            MoreChanges();
                            break;

                        case 3:
                            _temperature = 40;
                            MoreChanges();
                            break;

                        case 4:
                            _temperature = 60;                           
                            MoreChanges();
                            break;

                        case 5:
                            _temperature = 95;
                            MoreChanges();
                            break;
                    }                    
                    break;

                case 2:
                    ShowMessages.ShowRinseChanges();
                    int selectionRinse = SetValues.ListOfRinseChanges();

                    switch (selectionRinse)
                    {
                        case 1:
                            _numbRinses = 1;                           
                            MoreChanges();
                            break;

                        case 2:
                            _numbRinses = 2;                            
                            MoreChanges();
                            break;

                        case 3:
                            _numbRinses = 3;                            
                            MoreChanges();
                            break;
                    }
                    break;

                case 3:
                    ShowMessages.ShowSpinningChanges();
                    int selectionSpinning = SetValues.ListOfSpinningChanges();

                    switch (selectionSpinning)
                    {
                        case 1:
                            _spinning = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*Отжим отключен!");
                            Console.WriteLine("---------------");
                            Console.ResetColor();                            
                            MoreChanges();
                            break;

                        case 2:
                            _spinning = 400;
                            MoreChanges();
                            break;

                        case 3:
                            _spinning = 600;
                            MoreChanges();
                            break;

                        case 4:
                            _spinning = 800;
                            MoreChanges();
                            break;

                        case 5:
                            _spinning = 1000;
                            MoreChanges();
                            break;

                        case 6:
                            _spinning = 1200;
                            MoreChanges();
                            break;
                    }
                    break;

                case 4:
                    ShowMessages.ShowEcobubleChanges();
                    int selectionEcobuble = SetValues.ListOfEcobubleChanges();

                    switch (selectionEcobuble)
                    {
                        case 1:
                            _ecobuble = "Включен";
                            MoreChanges();
                            break;

                        case 2:
                            _ecobuble = "Выключен";
                            MoreChanges();
                            break;                        
                    }
                    break;

                case 5:
                    Console.Clear();
                    ShowMessages.ListOfPrograms();
                    SetValues.SelectionConditionsProgram();
                    
                    break;

                case 0:                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Стирка началась без изменений программы...");
                    Console.ResetColor();
                    break;                   
            }
        }
        
        /// <summary>
        /// Метод предлагает сделать дополнительные изменения программы.
        /// </summary>
        public virtual void MoreChanges()
        {                      
            ShowMessages.ShowMessage();
            SetProgram();
            if (CheckInput.CheckChanges())
                SetOfProgramChanges();
        }        
    }
}
