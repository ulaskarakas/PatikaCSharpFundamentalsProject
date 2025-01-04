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
                string? option = Console.ReadLine();
                if (option == "1"|| option == "2" || option == "3")
                {
                    Console.Write("\nLoading...");
                    Thread.Sleep(1300);
                    Console.Clear();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("- Random Number Finding Game -");
                            Console.WriteLine("Welcome to the Random Number Finding Game!\nGuess a number between 1 and 100.");

                            // Defines variables
                            int life = 5;

                            // Generates random number 
                            Random random = new Random();
                            int rnd = random.Next(1, 100);
                            
                            // Wait 1 second
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
                                            Console.WriteLine($"Enter a larger number.");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Enter a smaller number.");
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
                            
                            // Define variables
                            double firstNumber, secondNumber;

                            // Asks for the first number
                            Console.Write("Please enter the first value for the operation: ");
                            while (!double.TryParse(Console.ReadLine(), out firstNumber))
                            {
                                Console.Write("Invalid value! Please enter a number: ");
                            }

                            // Asks for the second number
                            Console.Write("Please enter the second value for the operation: ");
                            while (!double.TryParse(Console.ReadLine(), out secondNumber))
                            {
                                Console.Write("Invalid value! Please enter a number: ");
                            }

                            while(true)
                            {
                                // Asks for the operation
                                Console.Write("Please select the operation you want to perform (+, -, *, /): ");
                                string? operation = Console.ReadLine();
                                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                                {
                                    switch (operation)
                                    {
                                        case "+":
                                            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                                            break;
                                        case "-":
                                            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                                            break;
                                        case "*":
                                            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                                            break;
                                        case "/":
                                            if (secondNumber != 0)
                                            {
                                                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{firstNumber} cannot be divided by 0!");
                                            }
                                            break;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.Write("You have entered an invalid value. Please enter a valid value (+, -, *, /).\n");
                                }
                            }

                            break;
                        case "3":
                            Console.WriteLine("- Average Calculation -");

                            // Object creation
                            Program program = new Program();

                            // Define variables
                            double firstGrade, secondGrade, thirdGrade, averageGrade;
                            string letterGrade;

                            // Asks for the first grade
                            Console.Write("Please enter the first grade: ");
                            while (!double.TryParse(Console.ReadLine(), out firstGrade) || firstGrade < 0 || firstGrade > 100)
                            {
                                Console.Write("Invalid value! Please enter a grade between 0 and 100: ");
                            }

                            // Asks for the second grade
                            Console.Write("Please enter the second grade: ");
                            while (!double.TryParse(Console.ReadLine(), out secondGrade) || secondGrade < 0 || secondGrade > 100)
                            {
                                Console.Write("Invalid value! Please enter a grade between 0 and 100: ");
                            }

                            // Asks for the third grade
                            Console.Write("Please enter the third grade: ");
                            while (!double.TryParse(Console.ReadLine(), out thirdGrade) || thirdGrade < 0 || thirdGrade > 100)
                            {
                                Console.Write("Invalid value! Please enter a grade between 0 and 100: ");
                            }

                            // Calculate average of grades
                            averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;

                            // Call LetterGrade Method
                            letterGrade = program.LetterGrade(averageGrade);

                            Console.WriteLine($"Average of Grades is {averageGrade}\nLetter Grade is {letterGrade}");

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

        // Letter Grade Method
        string LetterGrade(double averageGrade)
        {
            if (averageGrade >= 90 && averageGrade <= 100)
                return "AA";
            else if (averageGrade >= 85 && averageGrade < 90)
                return "BA";
            else if (averageGrade >= 80 && averageGrade < 85)
                return "BB";
            else if (averageGrade >= 75 && averageGrade < 80)
                return "CB";
            else if (averageGrade >= 70 && averageGrade < 75)
                return "CC";
            else if (averageGrade >= 65 && averageGrade < 70)
                return "DC";
            else if (averageGrade >= 60 && averageGrade < 65)
                return "DD";
            else if (averageGrade >= 55 && averageGrade < 60)
                return "FD";
            else
                return "FF";
        }

    }
}