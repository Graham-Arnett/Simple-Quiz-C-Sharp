namespace Simple_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my simple quiz app");

            //String[] questions = {"\nWhat color is the sky? Blue, Red, or Orange? ","\nWhat programming language is this? C#, Java, or Python? ","\nWhat is the first letter of my name? G, J, or K? "};
            //foreach (String question in questions) { 
            //Console.WriteLine(question);
            //    string answer = Console.ReadLine().ToLower();
            //    if (answer == "true") 
            //    {

            //    }
            Console.WriteLine("What color is the sky? blue, red, or orange? ");
            string answerOne = Console.ReadLine().ToLower();
            if (answerOne == "blue")
            {
                Console.WriteLine("Correct!");
            }
            Console.WriteLine("What programming language did I write this in? C# or Java? ");
            string answerTwo = Console.ReadLine().ToLower();
            if(answerTwo == "c#")
            {
                Console.WriteLine("Correct!");
            }
            Console.WriteLine("What initial does my first name start with? ");
            string initial = Console.ReadLine().ToLower();
            if (initial == "g")
            {
                Console.WriteLine("Correct");

            }
            
            }
        }
    }

