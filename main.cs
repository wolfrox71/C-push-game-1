using System;
using Block;
using Board;
using Player;
class Program {
    public static void Main (string[] args) {
        var board = new Board.board(6,6);
        board.addItem(0,0);
        board.addItem(1,2);
        var player1 = new Player.player(1,1, board);
        
        board.showBoard();
        player1.moveLeft();
        board.showBoard();
        player1.moveUp();

        bool GameIsOn = true;
        while (GameIsOn)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            player1.moveLeft();
                            continue;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            player1.moveRight();
                            continue;
                        }
                    case ConsoleKey.UpArrow:
                        {
                           player1.moveUp();
                           continue;
                        }
                    case ConsoleKey.DownArrow:
                        {
                          player1.moveDown();
                          continue;
                        }
                    case ConsoleKey.Escape:
                        {
                            /* Exit game*/
                            GameIsOn = false; 
                            continue;
                        }
                    default:
                        {continue;}
                }
            }
            Console.Clear();
            board.showBoard();
            System.Threading.Thread.Sleep(1 * 1000); // sleep for 1 sec
        }
    }
}