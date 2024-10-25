namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber  = r.Next(1, 11);
            int response = 0;

            while (response != favNumber)
            {
              Console.WriteLine("Give me a number between 1 and 10:");
              response = int.Parse(Console.ReadLine());
              
                          if (response < favNumber)
                          {
                              Console.WriteLine($"Too Low!\nYour guess: {response}");
                          }
                          else if (response > favNumber)
                          {
                              Console.WriteLine($"Too High!\nYour guess: {response}");
                          }
                          else
                          {
                              Console.WriteLine($"You guessed it!\nThe favorite number was {favNumber}!");
                          }  
            }
            
        }
    }
}
