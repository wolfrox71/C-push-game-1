namespace Player {
    using Item;
    using Board;
    using System;
    class player: Item.item {
        int boardHeight;
        int boardWidth;
        Board.board board;
        public player(int entered_x, int entered_y, Board.board entered_board) {
            x = entered_x;
            y = entered_y;
            board = entered_board;
            if (board.validPosition(x,y)) {
                Console.WriteLine("Valid");
                board.addItem(x,y);
            } else {
                Console.WriteLine("Invalid Postion");
            }
            pushable = true;
            boardWidth = board.width;
            boardHeight = board.height;
        }
        public void moveLeft() {
            if (board.validPosition(x-1,y)) {
                board.removeItem(x,y);
                x--;
                board.addItem(x,y);
                
                board.showBoard();
            }
        }
        public void moveRight() {
            if (board.validPosition(x+1,y)) {
                board.removeItem(x,y);
                x++;
                board.addItem(x,y);
                
                board.showBoard();
            }
        }
        public void moveUp() {
            if (board.validPosition(x,y-1)) {
                board.removeItem(x,y);
                y--;
                board.addItem(x,y);
                
                board.showBoard();
            }
        }
        public void moveDown() {
            if (board.validPosition(x,y+1)) {
                board.removeItem(x,y);
                y++;
                board.addItem(x,y);
                
                board.showBoard();
            }
        }
    }
}