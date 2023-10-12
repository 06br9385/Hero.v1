using System.Speech.Synthesis;

namespace ConsoleApp1
{
    public static class Menu
    {
        private static Task<Dictionary<int, string>> GetMenuItems()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            result.Add(1, "1-Günler");
            result.Add(2, "2-Aylar");
            result.Add(3, "3-Mevsimler");
            return Task.FromResult(result);
        }

        public static ConsoleKeyInfo GetMenu()
        {
            Console.WriteLine("My name is Hero, Welcome to Learn English.");
            Talk.GetSpeech("My names is Hero, Welcome to Learn English.",1);
            foreach (var item in GetMenuItems().Result.ToList())
            {
                Console.WriteLine();
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }
            Console.Write("Öğrenmek İstediğin Konuyu Seçermisin? => ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            return key;
        }
    }
}
