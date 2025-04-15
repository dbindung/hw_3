public static class Task4 {
    public static void Run() {
        string[] heroes = {
            "Invoker (керри)",
            "Juggernaut (двойка)",
            "Lina (тройка)",
            "Shadow Fiend (четверка)",
            "Pudge (пятерка)"
        };

        Console.WriteLine("Список героев:");
        for (int i = 0; i < heroes.Length; i++) {
            Console.WriteLine(heroes[i]);
        }

        Console.Write("Введите имя героя: ");
        string input = Console.ReadLine();

        int index = FindHero(heroes, input);

        if (index == -1) {
            Console.WriteLine("Герой не найден.");
        } else {
            Console.WriteLine($"Герой найден на позиции {index + 1}.");
        }
    }
    static int FindHero(string[] heroes, string name) {
        for (int i = 0; i < heroes.Length; i++) {
            if (heroes[i].StartsWith(name)) {
                return i;
            }
        }
        return -1;
    }
}