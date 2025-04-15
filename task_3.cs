public static class Task3 {
    public static void Run() {
        Console.Write("Введите силу: ");
        int strength = int.Parse(Console.ReadLine());

        Console.Write("Введите ловкость: ");
        int agility = int.Parse(Console.ReadLine());

        Console.Write("Введите интеллект: ");
        int intelligence = int.Parse(Console.ReadLine());

        int health = strength * 20;
        int mana = intelligence * 12;
        double attackSpeed = agility * 0.5;

        Console.WriteLine($"Здоровье: {health}");
        Console.WriteLine($"Мана: {mana}");
        Console.WriteLine($"Скорость атаки: {attackSpeed.ToString()}");
    }
}