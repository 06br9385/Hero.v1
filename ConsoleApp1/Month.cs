using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Month
    {
        private static Task<Dictionary<string, string>> GetMonthItems()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("January",  "Ocak");
            result.Add("February",  "Şubat");
            result.Add("March",  "Mart");
            result.Add("April",  "Nisan");
            result.Add("May",  "Mayıs");
            result.Add("June",  "Haziran");
            result.Add("July",  "Temmuz");
            result.Add("August",  "Ağustos");
            result.Add("September",  "Eylül");
            result.Add("October",  "Ekim");
            result.Add("November",  "Kasım");
            result.Add("December",  "Aralık");

            return Task.FromResult(result);
        }

        public static void GetMonth()
        {

            Console.Clear();
            int count = 0;
            foreach (var item in GetMonthItems().Result.ToList())
            {
                count++;
                Console.ForegroundColor = (ConsoleColor)count + 1;
                Console.WriteLine($"{item.Value} YILIN {count}.AYIDIR => {item.Key} diye yazılır.");
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
                Console.Write($"YILIN {count}.AYINI İngilizce yazarmısın => ");
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
