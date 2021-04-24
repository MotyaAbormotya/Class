using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
        public Player(int x, int y, char symbol, ConsoleColor color)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Color = color;
        }
    }

    class CreateChela
    {
        public ConsoleColor Color;
        public char Symbol;
        public Random random = new Random();
        public int X;
        public int Y;

        public static ConsoleColor Colors(ConsoleColor Color, Random random)
        {
            int numRandom = random.Next(1, 5 + 1);
            switch (numRandom)
            {
                case 1:
                    Color = ConsoleColor.Green;
                    Console.ForegroundColor = Color;
                    Console.Write(Color);
                    break;
                case 2:
                    Color = ConsoleColor.Red;
                    Console.ForegroundColor = Color;
                    Console.Write(Color);
                    break;
                case 3:
                    Color = ConsoleColor.Yellow;
                    Console.ForegroundColor = Color;
                    Console.Write(Color);
                    break;
                case 4:
                    Color = ConsoleColor.White;
                    Console.ForegroundColor = Color;
                    Console.Write(Color);
                    break;
                case 5:
                    Color = ConsoleColor.Blue;
                    Console.ForegroundColor = Color;
                    Console.Write(Color);
                    break;
            }
            return Color;
            Console.ReadKey();
        }

        public static char Symbols(char Symbol, Random random)
        {
            int numRandom = random.Next(1, 5 + 1);
            switch (numRandom)
            {
                case 1:
                    Symbol = '$';
                    break;
                case 2:
                    Symbol = 'T';
                    break;
                case 3:
                    Symbol = '@';
                    break;
                case 4:
                    Symbol = 'ж';
                    break;
                case 5:
                    Symbol = 'ч';
                    break;
            }
            return Symbol;
        }

        public static int XY(int X, ref int Y, Random random)
        {
            X = random.Next(1, 15);
            Y = random.Next(1, 15);
            return X;
        }

        Player[] player = { new Player(X, Y, Symbol, Color) };
    }



    class Rendering
    {
        public Player[] player;

        public void RenderingPlayer()
        {
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(player[i].X, player[i].Y);
                Console.ForegroundColor = player[i].Color;

                Console.Write(player[i].Symbol);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          

            Rendering rendering = new Rendering();

            rendering.RenderingPlayer();

            Console.ReadKey();
        }
    }
}
