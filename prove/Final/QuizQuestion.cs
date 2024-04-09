namespace Final;

public class QuizQuestion
{
    private Flashcard card;
    private string answer;
    private string answerLetter;

    public QuizQuestion(List<Flashcard> flashcards,Flashcard card)
    {
        this.card = card;
        answer = card.front;
        Display(GetAnswers(flashcards));
    }

    private void Display(List<string> answers)
    {
        AnswerLetter(answers);
        Console.WriteLine($"{card.back}\n");
        Console.WriteLine($"a. {answers[0]}\n" +
                          $"b. {answers[1]}\n" +
                          $"c. {answers[2]}\n" +
                          $"d. {answers[3]}");
}

    private List<string> GetAnswers(List<Flashcard> flashcards)
    {
        bool isDistinct = false;
        HashSet<string> answers;
        
        answers = new HashSet<string>();
        Random random = new Random();
        while (answers.Count < 3)
        {
            var randomint = random.Next(0, flashcards.Count);
            var randomAnswer = flashcards[randomint].front;

            if (randomAnswer != answer)
            {
                answers.Add(randomAnswer); 
            }
            
        }

        answers.Add(answer);

        answers = Randomizer(answers);
        
        
        return answers.ToList();
    }

    private HashSet<string> Randomizer(HashSet<string> list)
    {
        List<string> listed = list.ToList();
        HashSet<string> hashSet = new HashSet<string>();
        Random random = new Random();
        while (hashSet.Count != list.Count)
        {
            var randomint = random.Next(0, list.Count);
            hashSet.Add(listed[randomint]);
        }

        return hashSet;
    }

    public bool IsCorrect(string userAnswer)
    {
        if (userAnswer.ToLower() == answerLetter)
        {
            Console.Clear();
            Console.WriteLine("GOOD JOB!");
            Thread.Sleep(2000);
            return true;
        }
        Console.Clear();
        Console.WriteLine("WOMP WOMP!");
        Console.WriteLine($"Correct answer was {answerLetter}. {answer}");
        Thread.Sleep(2000);
        return false;
    }

    private void AnswerLetter(List<string> list)
    {
        int answerLetterIndexOf = list.IndexOf(answer);

        switch (answerLetterIndexOf)
        {
            case 0:
                answerLetter = "a";
                break;
            case 1:
                answerLetter = "b";
                break;
            case 2:
                answerLetter = "c";
                break;
            case 3:
                answerLetter = "d";
                break;
        }

    }
}