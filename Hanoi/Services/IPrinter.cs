using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi.Services
{
    public interface IPrinter
    {
        void PrintHanoi();
        void PrintMessage(string message);
        void ClearScreen();
        string GetMessage();
        void WaitToUserConfimartion();
        void ColorMessage(string message, string message2, int a, int b);
        void WriteOneLine(string message);
        void PrintMessage(string prefix, string message);
    }
}
