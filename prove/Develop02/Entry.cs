namespace Develop02;

    using System;
    using System.Collections.Generic;

    public class Entry
    {
        public string Response;
        public string Prompt;
        public string Date = DateTime.Now.ToString("MMM d yyyy");
        
        public string entry;
        public string exportString;

        // Constructors
        public Entry()
        {
            string randomPrompt = GetPrompt();
            Console.WriteLine(randomPrompt);
            string something = Console.ReadLine();
        
            entry = CreateEntryString(something, randomPrompt);
            exportString = CreateExportString(something, randomPrompt);
        }

        public Entry(string entries)
        {
            var parts = entries.Split("|");
            Date = parts[0];
            Prompt = parts[1];
            Response = parts[2];

            entry = CreateEntryString(Response, Prompt);
            exportString = CreateExportString(Response, Prompt);
        }

        // Methods
        private string CreateEntryString(string import, string prompt)
        {
            string finalEntry = ($"Date:\n" +
                                 $"{Date}\n" +
                                 $"Prompt of the entry: '{prompt}' \n" +
                                 $"--------------------------ENTRY------------------------\n" +
                                 $"{import}");
            return finalEntry;
        }

        public string CreateExportString(string import, string prompt)
        {
            string exportString = $"{Date}|{Prompt}|{import}";
            return exportString;
        }

        public void Display()
        {
            Console.WriteLine(entry + "\n");
        }

        public string GetPrompt()
        {
            // I DID USE CHATGPT FOR A LIST OF PROMPTS, I HAD BORING PROMPTS 
          List<string> prompts = new List<string>()
{
    "How was your day?",
    "Who did you meet?",
    "Tell me about a book or movie that impacted you recently.",
    "What are you grateful for today?",
    "Describe a challenge you overcame recently and how you did it.",
    "If you could time travel, where and when would you go?",
    "What are your top three priorities for the week?",
    "Describe a place you've always wanted to visit and why.",
    "What's something that made you laugh recently?",
    "Reflect on a decision you made recently. How do you feel about it now?",
    "Share a favorite quote and explain why it resonates with you.",
    "What's a skill you'd like to learn or improve upon?",
    "Write about a moment that made you feel proud of yourself.",
    "Describe your ideal day from start to finish.",
    "What's something you've been procrastinating on? Why?",
    "Share a childhood memory that still brings you joy.",
    "Reflect on a time when you felt out of your comfort zone. What did you learn?",
    "If you could have dinner with anyone, living or dead, who would it be and why?",
    "Write about a hobby or interest you're passionate about.",
    "What's a goal you've set for yourself recently? How's your progress?",
    "Share something you've learned recently that surprised you.",
    "Describe a random act of kindness you've witnessed or experienced.",
    "What's a habit you'd like to break or develop?",
    "Write about a moment when you felt inspired or motivated.",
    "If you could change one thing about the world, what would it be?",
    "Share a recipe you love and why it's special to you.",
    "What's a piece of advice you'd give to your younger self?",
    "Describe your perfect day off. What would you do?",
    "Reflect on a time when you felt truly happy. What contributed to that feeling?",
    "What's something you're looking forward to in the near future?",
    "Write about a song that holds special meaning for you and why.",
    "If you could learn any language, which one would you choose and why?",
    "What's something you've been avoiding that you know you need to address?",
    "Describe a recent act of kindness you performed for someone else.",
    "Reflect on a time when you felt grateful for a small moment or gesture.",
    "Share a piece of advice someone gave you that stuck with you.",
    "What's a documentary or podcast you've listened to recently? What did you learn?",
    "If you could live in any time period, past or future, when would you choose and why?",
    "Write about a goal you've achieved and how it has impacted your life.",
    "Describe a place from your childhood that holds fond memories for you.",
    "Reflect on a time when you had to step out of your comfort zone. What did you learn?",
    "What's a small change you could make in your daily routine to improve your life?",
    "Share a quote or saying that inspires you to keep going during tough times.",
    "If you could have any superpower, what would it be and how would you use it?",
    "Write about a recent experience that challenged your perspective on something.",
    "What's a lesson you've learned from a mistake you made?",
    "Describe a recent accomplishment you're proud of and why.",
    "Reflect on a time when you had to overcome a fear. How did you do it?",
    "What's something you've been meaning to try but haven't gotten around to yet?",
    "Share a memory from your childhood that still makes you smile.",
    "If you could meet your role model, what would you ask them?",
    "Write about a recent encounter with nature that left you in awe.",
    "What's a piece of advice you'd give to someone facing a difficult decision?",
    "Describe a time when you felt truly alive and in the moment.",
    "Reflect on a time when you felt proud of someone else's accomplishment.",
    "What's a skill or talent you wish you had?",
    "Write about a recent experience that taught you something new about yourself.",
    "Share a story about a teacher or mentor who made a positive impact on your life.",
    "If you could relive one day from your past, which one would it be and why?",
    "Describe a moment when you felt deeply connected to someone else.",
    "What's something you've been meaning to forgive yourself or someone else for?",
    "Reflect on a time when you had to make a difficult decision. What factors influenced your choice?",
    "Write about a recent experience that restored your faith in humanity.",
    "If you could spend a day in someone else's shoes, who would you choose and why?",
    "Describe a recent adventure or spontaneous decision you made.",
    "What's a small act of self-care you've practiced recently?",
    "Reflect on a time when you had to stand up for what you believe in. How did it feel?",
    "What's something you've been avoiding that you know you need to confront?",
    "Write about a moment when you felt completely at peace with yourself and the world.",
    "If you could give one piece of advice to your future self, what would it be?",
    "Describe a recent act of generosity you witnessed or experienced.",
    "What's a goal you're currently working towards? What steps are you taking to achieve it?",
    "Reflect on a time when you felt inspired by someone else's kindness or compassion.",
    "Write about a place you've always wanted to visit but haven't had the chance to yet.",
    "If you could change one thing about yourself, what would it be and why?",
    "Describe a recent moment of joy or contentment that took you by surprise.",
    "What's a dream or aspiration you've held onto since childhood?",
    "Reflect on a time when you had to let go of something or someone. What did you learn?",
    "What's a small gesture of kindness you could perform for someone else today?",
    "Write about a time when you felt truly seen and understood by someone else.",
    "If you could have dinner with any historical figure, who would you choose and why?",
    "Describe a recent experience that challenged your assumptions or beliefs.",
    "What's a lesson you've learned from a difficult experience or setback?",
    "Reflect on a time when you felt proud of someone you care about. What did they achieve?",
    "Write about a place from your past that holds bittersweet memories for you.",
    "If you could travel back in time and give your younger self advice, what would it be?",
    "Describe a moment when you felt a deep sense of belonging or connection.",
    "What's a fear you've overcome recently? How did you do it?",
    "Reflect on a time when you had to choose between two difficult options. What did you decide?",
    "What's a hobby or interest you've been meaning to pursue but haven't had the chance to?",
    "Write about a recent experience that challenged your perspective on something important.",
    "If you could have any job in the world, what would it be and why?",
    "Describe a recent experience that made you feel grateful for the people in your life.",
    "What's a goal you've achieved recently that you're proud of?",
    "Reflect on a time when you felt deeply inspired by someone else's words or actions.",
    "Write about a place in nature that holds special meaning for you and why.",
    "If you could relive one moment from your past, which one would it be and why?",
    "Describe a recent act of kindness you performed for yourself or someone else.",
    "What's a decision you've made recently that you feel good about?",
    "Reflect on a time when you had to take a leap of faith. What did you learn?",
    "What's a new skill or hobby you'd like to try in the near future?",
    "Write about a moment when you felt overwhelmed with gratitude or joy.",
    "If you could travel anywhere in the world right now, where would you go and why?",
    "Describe a recent experience that restored your faith in humanity.",
    "What's a lesson you've learned from a mistake or failure?",
    "Reflect on a time when you felt deeply connected to something greater than yourself.",
    "What's a goal you're currently working towards? How do you plan to achieve it?",
    "Write about a person in your life who inspires you and why.",
    "If you could change one thing about the world, what would it be and why?",
    "Describe a recent experience that challenged your assumptions or beliefs.",
    "What's a small act of kindness you could perform for someone else today?",
    "Reflect on a time when you had to choose between two difficult options. What did you decide?",
    "What's a fear you've overcome recently? How did you do it?",
    "Write about a place from your past that holds bittersweet memories for you.",
    "If you could travel back in time and give your younger self advice, what would it be?",
    "Describe a moment when you felt a deep sense of belonging or connection.",
    "What's a hobby or interest you've been meaning to pursue but haven't had the chance to?",
    "Reflect on a time when you felt deeply inspired by someone else's words or actions.",
    "Write about a place in nature that holds special meaning for you and why.",
    "If you could relive one moment from your past, which one would it be and why?",
    "Describe a recent act of kindness you performed for yourself or someone else.",
    "What's a decision you've made recently that you feel good about?",
    "Reflect on a time when you had to take a leap of faith. What did you learn?",
    "What's a new skill or hobby you'd like to try in the near future?",
    "Write about a moment when you felt overwhelmed with gratitude or joy.",
    "If you could travel anywhere in the world right now, where would you go and why?",
    "Describe a recent experience that restored your faith in humanity.",
    "What's a lesson you've learned from a mistake or failure?",
    "Reflect on a time when you felt deeply connected to something greater than yourself.",
    "What's a goal you're currently working towards? How do you plan to achieve it?",
    "Write about a person in your life who inspires you and why."
};


            Random random = new Random();
            int randomIndex = random.Next(0, prompts.Count);
            string randomPrompt = prompts[randomIndex];

            return randomPrompt;
        }
    }

