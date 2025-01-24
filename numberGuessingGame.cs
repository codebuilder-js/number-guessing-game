using System;
class NumberGuessingGame {
    static void Main() {
        bool isCorrectGuess = false;
        
        Random random = new Random();
        
        int randomNumber = random.Next(1, 11);
        
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("A number between 1 and 10 will be generated.");
        Console.WriteLine("If you guess the correct number, you win!");
        
        while(!isCorrectGuess) {
            Console.Write("Please, enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            
            if(guess > randomNumber) {
                Console.WriteLine("Your guess is too high.");
            } else if(guess < randomNumber) {
                Console.WriteLine("Your guess is too low.");
            } else {
                Console.WriteLine("Correct!");
                isCorrectGuess = true;
            }
        }
        
        Console.WriteLine("Congratulations! You have won the game!");
        
        Console.ReadKey();
    }
}
