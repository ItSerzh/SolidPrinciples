using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    public class ConsoleInput : IInput
    {
        public int ReadLine()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
