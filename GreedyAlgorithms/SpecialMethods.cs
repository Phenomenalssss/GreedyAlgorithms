using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms
{
    public static class SpecialMethods
    {
        public static void ColorPrint(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
