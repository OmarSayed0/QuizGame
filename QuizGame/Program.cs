namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz Game!");
            Console.WriteLine("-------------------------");

            string[] questions = new string[]
            {
                "What is the capital of France?",
                "What is the capital of Germany?",
                "What is the capital of Spain?",
                "What is the capital of Italy?",
                "What is the capital of the United Kingdom?"
            };
            string[] answers = new string[]
            {
                "Paris",
                "Berlin",
                "Madrid",
                "Rome",
                "London"
            };
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer = Console.ReadLine();
                
                IsCorrectAnswer(userAnswer, answers[i]);

            }

        }
        private static void IsCorrectAnswer(string userAnswer, string correctAnswer)
        {
            
            if (userAnswer.ToUpper() == correctAnswer.ToUpper())
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }


        }
    }
}