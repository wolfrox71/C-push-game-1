namespace Item{
    using Board;
    using System;
    class item{
        public int x { get; set; }
        public int y { get; set; }
        public bool pushable { get; set; }
        public ConsoleColor forgroundColour = ConsoleColor.Red;
        public ConsoleColor backgroundColour = ConsoleColor.Black;
        public int symbol = 1;
        public item(){}
        public void draw () {
            Console.BackgroundColor = backgroundColour;
            Console.ForegroundColor = forgroundColour;
            Console.Write(symbol);
            Console.ResetColor();
        }
        public bool validPosition(Board.board playingBoard) {
            return true;
        }
        public void outputValues () {
            Console.WriteLine("----------------");
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
            Console.WriteLine($"Pushable: {pushable}");
            Console.WriteLine($"Symbol: {symbol}");
            Console.WriteLine("----------------");
        }
    }
}