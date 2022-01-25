namespace Board {
    using System;
    class board {
        public int width;
        public int height;
        public bool[,] positions;
        public board(int entered_height=5, int entered_width=5) {
            width = entered_width;
            height = entered_height;
            positions = new bool[height, width];
        }
        public bool validPosition(int x, int y) {
            if (!(x >= 0 && x < width)) { // if the position is off the screen to the side
                return false; // return false
            }
            if (!(y >= 0 && y < height)) { // if the position is off the screen up/down
                return false; // return false
            }
            return (!positions[y,x]);
        }

        public bool addItem(int x, int y){
            if (validPosition(x,y)) {
                positions[y,x] = true;
                return true;
            }
            return false;
        }
        public bool removeItem(int x, int y){
            if (!validPosition(x,y)) {
                positions[y,x] = false;
                return true;
            }
            return false;
        }


        public void showBoard() {
        for (int x = 0; x < positions.GetLength(0); x++) {
            for (int y = 0; y < positions.GetLength(1); y++) {
                Console.ResetColor();
                if (!positions[x,y]) {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(positions[x, y]);
                if (y!= positions.GetLength(1)-1) {
                    Console.Write("|");
                }
            }
            Console.WriteLine("");
            if (x!= positions.GetLength(0)-1) {
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("");
            }
            Console.ResetColor();
        } 
    }
}