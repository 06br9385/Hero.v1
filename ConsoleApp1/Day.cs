namespace ConsoleApp1
{
    public static class Day
    {

        private static Task<Dictionary<string, string>> GetDayItems()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("Monday", "Pazartesi");
            result.Add("Tuesday", "Salı");
            result.Add("Wednesday", "Çarşamba");
            result.Add("Thursday", "Perşembe");
            result.Add("Friday", "Cuma");
            result.Add("Saturday", "Cumartesi");
            result.Add("Sunday", "Pazar");

            return Task.FromResult(result);
        }

        public static void GetDay()
        {

            Console.Clear();
            int count = 0;
            foreach (var item in GetDayItems().Result.ToList())
            {
                count++;
                Console.ForegroundColor = (ConsoleColor)count + 1;
                Console.WriteLine($"{item.Value} HAFTANIN {count}.GUNU => {item.Key} diye yazılır.");
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
                Console.Write($"HAFTANIN {count}.GUNUNU İngilizce yazarmısın => ");
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
