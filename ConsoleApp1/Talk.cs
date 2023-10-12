using System.Speech.Synthesis;

namespace ConsoleApp1
{
    public static class Talk
    {
        public static void GetSpeech(string text, int repeatCount = 2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            SpeechSynthesizer _s = new SpeechSynthesizer();
            _s.Volume = 100;
            _s.Rate = -2;
            for (int i = 0; i < repeatCount; i++)
            {
                _s.Speak(text);
            }
        }
    }
}
