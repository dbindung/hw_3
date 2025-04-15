public static class Task1 {
    public static void Run() {
        Random rand = new Random();
        Console.Write("enter the amount of slayed creeps:");
        int creepCount = Convert.ToInt32(Console.ReadLine()), totalGold = 0, price;
        for (int i = 0; i < creepCount; i++) {
            price = rand.Next(30, 51);
            totalGold += price;
        }
        Console.WriteLine("you earned " + totalGold + " gold");
    }
}