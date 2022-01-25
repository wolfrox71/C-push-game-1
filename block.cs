namespace Block {
    using Item;
    class block: Item.item {
        public block(int entered_x, int entered_y) {
            x = entered_x;
            y = entered_y;
            pushable = true;
        }
    }
}