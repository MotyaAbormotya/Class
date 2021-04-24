using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassi
{
    class Player
    {
        public int X;
        public int Y;
        public char Symbol;
        public ConsoleColor Color;

        public Player(int x, int y, char symbol, ConsoleColor color)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Color = color;
        }
    }

    class Rendering
    {
        public Player[] player;

        public void RenderingPlayer(Player[] player)
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
            WalkingOnForm(5, 4,12, 6);
        }

        public static void WalkingOnForm(int playerPositionI, int playerPositionJ, int playerPositionI2, int playerPositionJ2)
        {
            int[,] map = new int[150, 150];
        
            while (true)
            {
                Console.Clear();
                Player[] player = { new Player( playerPositionI, playerPositionJ, '@', ConsoleColor.Red),
            new Player(playerPositionI2, playerPositionJ2, '$', ConsoleColor.Green) };
                Rendering rendering = new Rendering();
                rendering.RenderingPlayer(player);
                ConsoleKeyInfo userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.A:
                        if (playerPositionI - 1 > -1)
                        {
                            playerPositionI--;
                        }
                        break;
                    case ConsoleKey.W:
                        if (playerPositionJ - 1 > -1)
                        {
                            playerPositionJ--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (playerPositionI + 1 < map.GetLength(0))
                        {
                            playerPositionI++;
                        }
                        break;
                    case ConsoleKey.S:
                        if (playerPositionJ + 1 < map.GetLength(1))
                        {
                            playerPositionJ++;
                        }
                        break;
                    case ConsoleKey.E:
                        WalkingOnFormSecondPlayer(playerPositionI, playerPositionJ, playerPositionI2, playerPositionJ2);
                        break;
                }
            }
        }
        public static void WalkingOnFormSecondPlayer(int playerPositionI, int playerPositionJ, int playerPositionI2, int playerPositionJ2)
        {
            int[,] map = new int[150, 150];
            while (true)
            {
                Console.Clear();
                Player[] player = { new Player( playerPositionI, playerPositionJ, '@', ConsoleColor.Red),
            new Player(playerPositionI2, playerPositionJ2, '$', ConsoleColor.Green) };
                Rendering rendering = new Rendering();
                rendering.RenderingPlayer(player);
                ConsoleKeyInfo userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.A:
                        if (playerPositionI2 - 1 > -1)
                        {
                            playerPositionI2--;
                        }
                        break;
                    case ConsoleKey.W:
                        if (playerPositionJ2 - 1 > -1)
                        {
                            playerPositionJ2--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (playerPositionI2 + 1 < map.GetLength(0))
                        {
                            playerPositionI2++;
                        }
                        break;
                    case ConsoleKey.S:
                        if (playerPositionJ2 + 1 < map.GetLength(1))
                        {
                            playerPositionJ2++;
                        }
                        break;
                    case ConsoleKey.E:
                        WalkingOnForm(playerPositionI, playerPositionJ, playerPositionI2, playerPositionJ2);
                        break;
                }
            }
        }
    }
}

