using SConsole = System.Console;
using NiTiS.BaseLibrary;

namespace NiTiS.Tests.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SConsole.WriteLine(new VeryImportantClass().GetMessage());
        }
    }
}
