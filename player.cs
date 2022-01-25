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
            symbol = 2;
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

        
        public void moveLeft() {
            if (board.validPosition(x-1,y)) {
                board.move(x,y, x-1, y, symbol);
                x--;
                
                board.showBoard();
            }
            else {
                if (board.validPosition(x-2, y) && board.pushable(x-1, y)) {
                    board.move(x-1, y, x-2, y,4);
                    board.move(x,y, x-1, y, symbol);
                    x--;
                }
            }
        }
        public void moveRight() {
            if (board.validPosition(x+1,y)) {
                board.move(x,y, x+1, y, symbol);
                x++;
                
                board.showBoard();
            }
            else {
                if (board.validPosition(x+2, y) && board.pushable(x+1, y)) {
                    board.move(x+1, y, x+2, y,4);
                    board.move(x,y, x+1, y, symbol);
                    x++;
                }
            }
        }
        public void moveUp() {
            if (board.validPosition(x,y-1)) {
                board.move(x,y, x, y-1, symbol);
                y--;
                
                board.showBoard();
            }
            else {
                if (board.validPosition(x, y-2) && board.pushable(x, y-1)) {
                    board.move(x, y-1, x, y-2,4);
                    board.move(x,y, x, y-1, symbol);
                    y--;
                }
            }
        }
        public void moveDown() {
            if (board.validPosition(x,y+1)) {
                board.move(x,y, x, y+1, symbol);
                y++;
                
                board.showBoard();
            }
            else {
                if (board.validPosition(x, y+2) && board.pushable(x, y+1)) {
                    board.move(x, y+1, x, y+2,4);
                    board.move(x,y, x, y+1, symbol);
                    y++;
                }
            }
        }
    }
}