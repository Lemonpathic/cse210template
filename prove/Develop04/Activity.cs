using System.Diagnostics;
using System.Linq.Expressions;

namespace Develop04
{
    public class Activity
    {
        public virtual void Display(string message)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {message}.");
            GetReady();
        }

        protected void EndDisplay(string message, int time)
        {
            Console.Clear();
            Console.WriteLine($"You just completed another {time} seconds of {message}s");
            Thread.Sleep(1000);
            Console.WriteLine($"Hopefully you now feel more relaxed after completing the {message}");
            Spinner(100, 8);
            Console.Clear();
        }

        protected void Spinner(int sleepTime, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write("|");
                Thread.Sleep(sleepTime);
                Console.Write("\b \b"); // Erase the + character

                Console.Write("/");
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");

                Console.Write("-");
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");

                Console.Write(@"\");
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");
            }
        }

        private void GetReady()
        {
            Console.WriteLine("Get Ready . . .");
            Spinner(75, 4);
        }
    }

    public class BreathingExercise : Activity
    {
        private void BreathingDisplay()
        {
            var sleepTime = 1000;
            Console.WriteLine("\n");
            Console.Write("Breathe In...");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");
            }

            Console.WriteLine(" ");

            Console.Write("Now breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");
            }
            Console.Write("");
        }

        public override void Display(string message)
        {
            Console.Write("How long would you like to do this exercise for (in seconds): ");
            var input = int.Parse(Console.ReadLine());
            Timer timer = new Timer(input);

            base.Display("Breathing Exercise");

            timer.Start();
            while (!timer._isFinished)
            {
                BreathingDisplay();
            }
            EndDisplay("Breathing Exercise", input);
        }
    }

    public class Reflection : Activity
    {
        private List<string> prompts = new List<string>();
        private List<string> questions = new List<string>();
        private List<int> questionIndexes = new List<int>();
        private int counter;

        private void RunActivity()
        {
            // Initialize prompts and questions
            prompts.AddRange(new string[]
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            });

            questions.AddRange(new string[]
            {
                "Why was this experience meaningful to you",
                "Have you ever done anything like this before",
                "How did you get started",
                "How did you feel when it was complete",
                "What made this time different than other times when you were not as successful",
                "What is your favorite thing about this experience",
                "What could you learn from this experience that applies to other situations",
                "What did you learn about yourself through this experience",
                "How can you keep this experience in mind in the future"
            });
        }

        private string GenerateRandomPrompt(List<string> list)
        {
            Random random = new Random();
            var randomIndex = random.Next(list.Count);
            return list[randomIndex];
        }

        private string GenerateRandomQuestion(List<string> list)
        {
            int randomIndex;
            Random random = new Random();
            do
            {
                randomIndex = random.Next(list.Count);

            } while (questionIndexes.Contains(randomIndex));
            questionIndexes.Add(randomIndex);

            counter++;
            if (counter != questions.Count) return list[randomIndex];
            foreach (var index in questionIndexes)
            {
                questionIndexes.Remove(index);
            }
            counter = 0;
            return list[randomIndex];
        }

        public override void Display(string message)
        {
            RunActivity();

            Console.Write("How long would you like to do this exercise for (in seconds): ");
            var input = int.Parse(Console.ReadLine());

            base.Display("Reflection Exercise");
            Thread.Sleep(500);

            Console.WriteLine(GenerateRandomPrompt(prompts));
            Console.Write("When you are ready, press ENTER");
            Console.ReadLine();
            Spinner(75, 6);

            Timer timer = new Timer(input);
            timer.Start();
            while (!timer._isFinished)
            {
                Console.Write(GenerateRandomQuestion(questions) +"...");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("");
            }
            
            
            base.EndDisplay("Reflection Exercise", input);
        }
    }

    public class HolyGhostMoments : Activity
    {
        private List<string> prompts = new List<string>();

        private void BuildList()
        {
            // Add elements to the list
            prompts.AddRange(new string[]
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            });
        }

        private string GenerateRandom(List<string> list)
        {
            Random random = new Random();
            var randomInt = random.Next(list.Count);

            return list[randomInt];
        }

        public override void Display(string message)
        {
            BuildList();
            base.Display("Listing Activity");
            
            Console.Write("How long would you like to do this exercise for (in seconds): ");
            var input = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GenerateRandom(prompts));

            Timer timer = new Timer(input);
            timer.Start();

            while (!timer._isFinished)
            {
                Console.Write("> ");
                Console.ReadLine();
            }
            EndDisplay("Listing Activity", input);
        }
    }
}
