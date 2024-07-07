using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSimulator
{
    class game
    {
        int posX = 40, posY = 10;
        string simbolos = "^>v<";
        byte simboloActual = 0;
        bool terminado = false;

        public void run()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(posX, posY);
                Console.Write(simbolos[simboloActual]);
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.RightArrow) posX++;
                    if (tecla.Key == ConsoleKey.LeftArrow) posX--;
                    if (tecla.Key == ConsoleKey.Escape) terminado = true;
                }
                simboloActual++;
                if (simboloActual > 3) simboloActual = 0;
            }
            while (!terminado);
        }
    }
}
