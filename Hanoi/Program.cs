using Hanoi.OperationsOfHanoi;
using Hanoi.Services;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            var startHanoi = new HanoiMain(new ConsolePrinter("Wieża Hanoi"));
            startHanoi.DoOperations2();
        }
    }
}
