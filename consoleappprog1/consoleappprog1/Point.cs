using System;
using System.Collections.Generic;
using System.Text;

namespace consoleappprog1
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Аргумент переменной x не должен быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Аргумент переменной y не должен быть отрицательным");
        }
        public void SetSymbol(char symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            sym = symbol;
        }
    }
}
