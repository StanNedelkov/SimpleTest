using System;
using System.Threading;

namespace VisualConsoleTest
{
    class Engine
    {
        public void Run()
        {
            while (true)
            {
                Console.Write("Write>>");
                string input = Console.ReadLine();
                Console.Clear();
                if (IsCorrect(input))
                {
                    Reward reward = new Reward();
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine(reward.Get());
                        Thread.Sleep(1000);
                    }
                    continue;
                }
                for (int i = 5; i >= 0; --i)
                {
                    Console.WriteLine(Message() + i);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        private string Message() => ">>Sorry, wrong answer. Read my code to get the password.\r\nPlease wait ";

        private bool IsCorrect(string input) => input == password;

        private const string password = "I want to build a project";
    }
    
}
