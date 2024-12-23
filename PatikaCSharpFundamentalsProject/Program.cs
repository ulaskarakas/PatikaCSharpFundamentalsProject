using System;

namespace PatikaCSharpFundamentalsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays program options on console screen
            while (true)
            {
                Console.Write("Which program would you like to run?\n1 - Random Number Finding Game\n2 - Calculator\n3 - Average Calculation\nSelect one of the options above: ");
                string option = Console.ReadLine();
                if (option == "1"|| option == "2" || option == "3")
                {
                    Console.Write("\nLoading...");
                    Thread.Sleep(1300);
                    Console.Clear();

                    switch (option)
                    {
                        case "1":
                            //Defines variables
                            int life = 5;

                            // Generates random number 
                            Random random = new Random();
                            int rnd = random.Next(1, 100);

                            Console.WriteLine("- Random Number Finding Game -");
                            Console.WriteLine("Welcome to the Random Number Finding Game!\nGuess a number between 1 and 100.");
                            
                            //Wait 1 second
                            Thread.Sleep(1000);

                            while (life > 0)
                            {
                                // Asks for the number
                                Console.Write($"Your remaining life: {life} / Enter your guess: ");
                                if (int.TryParse(Console.ReadLine(), out int guessNumber))
                                {
                                    if (guessNumber == rnd)
                                    {
                                        Console.WriteLine("Your guess is correct, Congratulations!");
                                        break;
                                    }
                                    else
                                    {
                                        if (guessNumber < rnd )
                                        {
                                            Console.WriteLine($"Enter a larger number. ");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Enter a smaller number. ");
                                        }
                                        life--;
                                    }

                                    if (life == 0)
                                    {
                                        Console.WriteLine($"Sorry you couldn't guess. The correct number is {rnd}");
                                    }
                                }
                                else
                                {

                                    Console.Write("You have entered an invalid value. Please enter an integer value.\n");
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("- Calculator -");
                            break;
                        case "3":
                            Console.WriteLine("- Average Calculation -");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("You have selected an invalid option. Please select a valid option!");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
        }
    }
}


