namespace Game {
    using Board;
    using Player;
    using System;
    class game {
        Board.board board;
        Player.player player;
        double delay = 0.5; // in seconds
        bool GameIsOn;
        public game(Board.board enteredBoard, Player.player enteredPlayer) {
            board = enteredBoard;
            player = enteredPlayer;
        }

        public void play() {
            GameIsOn = true;
            while (GameIsOn){
                playerMove();
                Console.Clear();
                board.showBoard();
                System.Threading.Thread.Sleep(Convert.ToInt32(delay * 1000)); // sleep for 1 sec

            }
        }
        public void playerMove(){
            if (Console.KeyAvailable){
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key){
                    case ConsoleKey.LeftArrow:{
                            player.moveLeft();
                            return;
                        }
                    case ConsoleKey.RightArrow:{
                            player.moveRight();
                            return;
                        }
                    case ConsoleKey.UpArrow:{
                           player.moveUp();
                           return;
                        }
                    case ConsoleKey.DownArrow:{
                          player.moveDown();
                          return;
                        }
                    case ConsoleKey.Escape:{
                            /* Exit game*/
                            GameIsOn = false; 
                            return;
                        }
                    default:
                        {return;}
                }
            }
        }
    }
}