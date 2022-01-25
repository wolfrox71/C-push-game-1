namespace Goal {
    using Item;
    using System;
    using Board;
    class goal: Item.item {
        int boardHeight;
        int boardWidth;
        Board.board board;
        public goal(int entered_x, int entered_y, Board.board entered_board) {
            x = entered_x;
            y = entered_y;
            symbol = 3;
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