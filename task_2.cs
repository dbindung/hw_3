public static class Task2 {
    public static void Run() {
        Console.Write("enter the spell name: ");
        string spellName = Console.ReadLine().ToUpper();
        int spellLength = spellName.Length;
        Console.WriteLine("spell name: " + spellName);
        Console.WriteLine("spell length: " + spellLength);
    }
}