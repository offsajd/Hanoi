using System;
using System.Drawing;
using Hanoi.Services;
using Console = Colorful.Console;
using Hanoi.Exceptions;
using System.Threading;

namespace Hanoi.OperationsOfHanoi
{
    public class HanoiMain
    {
        private readonly IPrinter _printer;
        public HanoiMain(IPrinter printer)
        {
            _printer = printer;
        }

        public void TowerHanoiPrintInfo(int numberOfDisc, char fromRodHanoi, char toSpecificRod, char outRodHanoi)
        {
            if (numberOfDisc == 0)
            {
                return;
            }
            TowerHanoiPrintInfo(numberOfDisc - 1, fromRodHanoi, outRodHanoi, toSpecificRod);
            _printer.WriteOneLine("przesunięcie dysku  ");
            Console.Write(numberOfDisc, Color.Red);
            _printer.WriteOneLine("  ze słupka:  ");
            Console.Write(fromRodHanoi, Color.Cyan);
            _printer.WriteOneLine("  na słupek:  ");
            Console.WriteLine(toSpecificRod, Color.DarkOrange);
            TowerHanoiPrintInfo(numberOfDisc - 1, outRodHanoi, toSpecificRod, fromRodHanoi);
        }


        public void DoOperations2()
        {

            _printer.PrintMessage("                Wieża Hanoi ");
            _printer.PrintMessage("\t");
            _printer.PrintHanoi();
            _printer.PrintMessage("\t");
            _printer.PrintMessage("           Wpisz liczbę krążków:");
            var numbersOfDiskHanoiTower = int.Parse(_printer.GetMessage());
            if (numbersOfDiskHanoiTower > 0)
            {
                TowerHanoiPrintInfo(numbersOfDiskHanoiTower, 'A', 'C', 'B');
                Thread.Sleep(200);
                _printer.PrintMessage("\t");

                OverAndOverLoop();
            }
            else
                _printer.PrintMessage("Problem z liczbą krążków.");
        }
        public void OverAndOverLoop()
        {
            _printer.PrintMessage("Chcesz wypróbować program jeszcze raz?");
            _printer.PrintMessage("1", "TAK");
            _printer.PrintMessage("2", "NIE");
            var OptionOfOverALoopTrueOrFalse = _printer.GetMessage();
            if (OptionOfOverALoopTrueOrFalse == "1")
            {
                _printer.ClearScreen();
                var startHanoi = new HanoiMain(new ConsolePrinter("Wieża Hanoi"));
                startHanoi.DoOperations2();
            }
            else if (OptionOfOverALoopTrueOrFalse == "2")
            {
                _printer.ClearScreen();
                _printer.PrintMessage(" Do Zobaczenia!");
                Thread.Sleep(500);
                new ExitAppException();
            }
            else
            {
                _printer.PrintMessage("wybrałeś złą opcje!!!!");
                _printer.PrintMessage("wybierz 1 lub 2 na klawiaturze!!!!");
                Thread.Sleep(500);
                _printer.ClearScreen();
                OverAndOverLoop();
            }
        }
    }
}
