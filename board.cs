namespace Board {
    using System;
    class board {
        public int width;
        public int height;
        public int[,] positions;
        public board(int entered_height=5, int entered_width=5) {
            width = entered_width;
            height = entered_height;
            positions = new int[height, width];
        }
        public bool validPosition(int x, int y) {
            if (!(x >= 0 && x < width)) { // if the position is off the screen to the side
                return false; // return false
            }
            if (!(y >= 0 && y < height)) { // if the position is off the screen up/down
                return false; // return false
            }
            return ((positions[y,x] == 0));
        }
        public bool pushable(int x, int y) {
            switch (positions[y,x]) {
                case 0: case 4: case 2:  //yes
                    return true;
                case 3: case 1: //no
                    return false;
                default:
                    return false;
            } 
        }

        public bool addItem(int x, int y, int value){
            if (validPosition(x,y)) {
                positions[y,x] = value;
                return true;
            }
            return false;
        }
        public bool removeItem(int x, int y){
            if (!validPosition(x,y)) {
                positions[y,x] = 0;
                return true;
            }
            return false;
        }

        public void move(int original_x, int original_y, int new_x, int new_y, int symbol) {
            int type = positions[original_x,original_y];
            Console.WriteLine(removeItem(original_x, original_y));
            Console.WriteLine(addItem(new_x, new_y, symbol));
           }


        public void showBoard() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------");
            for (int x = 0; x < positions.GetLength(0); x++) {
                
                for (int y = 0; y < positions.GetLength(1); y++) {
                    Console.ResetColor();
                    if (!(positions[x,y]==0)) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    } else {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    switch (positions[x,y]) {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        default:
                            break;
                    }

                    Console.Write(positions[x,y]);
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