using System;

namespace consoleappprog1
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine h1 = new HorizontalLine(0, 10, 0, '*');
            h1.Draw();
            HorizontalLine h2 = new HorizontalLine(0, 10, 5, '*');
            h2.Draw();
            VerticalLine v1 = new VerticalLine(0, 5, 0, '*');
            v1.Draw();
            VerticalLine v2 = new VerticalLine(0, 5, 10, '*');
            v2.Draw();
        }
    }
}
