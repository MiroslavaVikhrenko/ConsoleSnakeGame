using System.Drawing;

namespace ConsoleSnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location head = new Location(40, 12);

            List<Location> snake = new List<Location>();
            snake.Add(head);

            Location next;

            Location food = new Location(60, 20);

            while (true)
            {
                next = snake[0];

                Console.Clear();
                // show snake

                foreach (Location location in snake)
                {
                    Console.SetCursorPosition(location.X, location.Y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("S");
                    Console.ResetColor();
                }
                // show food

                Console.SetCursorPosition(food.X, food.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('F');
                Console.ResetColor();

                // handle input

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.UpArrow:
                        if (next.Y > 0)
                            next.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (next.Y < 24)
                            next.Y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (next.X > 0)
                            next.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (next.X < 79)
                            next.X++;
                        break;
                }
                snake.Insert(0, next);
                if (next.X == food.X && next.Y == food.Y)
                {
                    Random random = new Random();
                    food.X = random.Next(0, 80);
                    food.Y = random.Next(0, 25);
                }
                else
                    snake.RemoveAt(snake.Count - 1);
            }
        }
    }
}
