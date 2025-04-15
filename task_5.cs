public static class Task5 {
    public static void Run() {
        Item BlinkDagger = new Item("Blink Dagger", 2250, "+15 к ловкости");
        BlinkDagger.PrintInfo();
    }
    public class Item {
        public string Name;
        public int Price;
        public string Bonus;

        public Item(string name, int price, string bonus) {
            Name = name;
            Price = price;
            Bonus = bonus;
        }
        public void PrintInfo() {
            Console.WriteLine($"Название предмета {Name}");
            Console.WriteLine($"Стоимость предмета {Price}");
            Console.WriteLine($"Бонус предмета {Bonus}");
        }
    }
}