namespace Block {
    using Item;
    using System;
    using Board;
    class block: Item.item {
        int boardHeight;
        int boardWidth;
        Board.board board;
        public block(int entered_x, int entered_y, Board.board entered_board) {
            x = entered_x;
            y = entered_y;
            symbol = 1;
            board = entered_board;
            if (board.validPosition(x,y)) {
                Console.WriteLine("Valid");
                board.addItem(x,y, symbol);
            } else {
                Console.WriteLine("Invalid Postion");
            }
            pushable = true;
            boardWidth = board.width;
            boardHeight = board.height;
        }
    }
}