using System;
using System.Drawing;
using Console = Colorful.Console;

namespace Hanoi.Services
{
   internal class ConsolePrinter : IPrinter
    {
        private readonly string _title;
        public ConsolePrinter(string title)
        {
            _title = title;
            SetConsoleTitle();
        }
        private void SetConsoleTitle()
        {
            Console.Title = _title;
        }
        public void ClearScreen()
        {
            Console.Clear();
        }

        public string GetMessage()
        {
            return Console.ReadLine();
        }

        public void PrintHanoi()
        {
            Console.Write("       ###", Color.Cyan); Console.Write("\t"); Console.Write(" #################", Color.Yellow); Console.WriteLine("      ###", Color.Cyan);
            Console.Write("    #########", Color.Red); Console.Write("       #############", Color.Green); Console.WriteLine("    #########", Color.Red);
            Console.Write("  #############", Color.Green); Console.Write("       #########", Color.Red); Console.WriteLine("    #############", Color.Green);
            Console.Write("#################", Color.Yellow); Console.Write("       ###", Color.Cyan); Console.WriteLine("      #################", Color.Yellow);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void WaitToUserConfimartion()
        {
            Console.ReadKey(true);
        }

        public void ColorMessage(string message, string message2, int a, int b)
        {
            //Console.Write("[");
            //Console.Write(message, Color.Gold);
            //Console.WriteLine("]" + message2);

            //Console.WriteLine("{0} -> {1}", palik[p], palik[q]);
        }

        public void WriteOneLine(string message)
        {
            Console.Write(message);
        }
        public void PrintMessage(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.Gold);
            Console.WriteLine("]" + message);
        }
    }
}
