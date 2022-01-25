using System;
using Block;
using Board;
using Player;
using Game;
using Goal;
using Loot;
class Program {
    public static void Main (string[] args) {
        var board = new Board.board(6,6);
        var block1 = new Block.block(0,0, board);
        var block2 = new Block.block(3,4, board);
        var player1 = new Player.player(1,1, board);
        var loot = new Loot.loot(5,4, board);
        var goal = new Goal.goal(5,5, board);
        Game.game game = new Game.game(board, player1);
        //board.showBoard();
        game.play();
    }
}