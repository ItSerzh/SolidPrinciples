using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
