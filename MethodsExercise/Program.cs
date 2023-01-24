namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int numOne, int numTwo)
        {// EXERCISE TWO
            return numOne + numTwo;

        }
        public static int Multiply(int numOne, int numTwo) 
        {
            return numOne * numTwo;
        }
        static void Main(string[] args)
        {
            
            // EXERCISE ONE
            Console.WriteLine("Hello! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine($"{favoriteColor}, wow! I never would have guessed. What about your favorite animal, {userName}?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"Cool! Important question: if you could pick one band to write a song about a {favoriteColor} {favoriteAnimal}, who would it be?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"The {favoriteColor} {favoriteAnimal}s by {favoriteBand} sounds like a song I would like to hear!");

            
            

        }
    }
}
