namespace Loot {
    using Item;
    using System;
    using Board;
    class loot: Item.item {
        int boardHeight;
        int boardWidth;
        Board.board board;
        public loot(int entered_x, int entered_y, Board.board entered_board) {
            x = entered_x;
            y = entered_y;
            symbol = 4;
            board = entered_board;
            if (board.validPosition(x,y)) {
                Console.WriteLine("Valid");
                board.addItem(x,y, symbol);
            } else {
                Console.WriteLine("Invalid Postion");
            }
            pushable = false;
            boardWidth = board.width;
            boardHeight = board.height;
        }
    }
}