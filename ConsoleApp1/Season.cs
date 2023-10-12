namespace ConsoleApp1
{
    public static class Season
    {
        private static Task<Dictionary<string, string>> GetSeasonItems()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("Winter", "Kış");
            result.Add("Spring", "İlkbahar");
            result.Add("Summer", "Yaz");
            result.Add("Autumn", "Sonbahar");

            return Task.FromResult(result);
        }

        public static void GetSeason()
        {

            Console.Clear();
            int count = 0;
            foreach (var item in GetSeasonItems().Result.ToList())
            {
                count++;
                Console.ForegroundColor = (ConsoleColor)count + 1;
                Console.WriteLine($"{item.Value} YILIN {count}.MEVSIMI => {item.Key} diye yazılır.");
                Talk.GetSpeech(item.Key);
                Console.Write("Diye okunur, Tekrar Dinlemek İstersen 1 e Devam Etmek için Enter a basarmısın => ");
                var key = Console.ReadKey();
                if (key.KeyChar == '1')
                {
                    Talk.GetSpeech(item.Key);
                }
                Console.WriteLine();
                Console.WriteLine("Duyduğun Kelimeyi 3 Defa Tekrar Ettikten sonra Enter a basarmısın");
                Console.ReadKey();
                Console.WriteLine();
                Console.Write($"YILIN {count}.MEVSIMI İngilizce yazarmısın => ");
                var x = Console.ReadLine();
                if (x.ToLower() == item.Key.ToLower())
                {
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("*************************DOĞRU YAZDIN***************************");
                    Console.WriteLine("****************************************************************");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine($"---------Yanlış Yazdın Doğrusu => {item.Key} olacaktı-----------");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            Console.Clear();
        }
    }
}
