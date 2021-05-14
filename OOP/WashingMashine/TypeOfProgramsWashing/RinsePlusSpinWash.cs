using System;

namespace WashingMashine.TypeOfProgramsWashing
{
    public class RinsePlusSpinWash : PatternProgramsWashing
    {
        public RinsePlusSpinWash() : base("Полоскание + Отжим", 0, 1, 1200, "Выключен") { }

        public override void SetOfProgramChanges()
        {
            ShowMessages.ShowRinsePlusSpinCanges();
            int selectionChanges = SetValues.ListOfRinsePlusSpinWash();

            switch (selectionChanges)
            {
                case 1:
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

                case 2:
                    ShowMessages.ShowSpinningChanges();
                    int selectionSpinning = SetValues.ListOfSpinningChanges();

                    switch (selectionSpinning)
                    {
                        case 1:
                            _spinning = 0;
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

                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Стирка началась без изменений программы...");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
