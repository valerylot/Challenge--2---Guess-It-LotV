//Valery Lot
//09/15/2026
//Challenge #2 Guess It
//We used the Random class to generate a random number then created a game where we ask the user to guess the number. They are able to choose which level difficulty or even custom range that they input themselves.
//Peer Review Name: Callen Thomason
/*
Flow chart is a little simple. There are process's that should be decisions
Code runs well, and the game plays as intended. 
On custom setting a max lower than the min causes a run time error. Try making a lower max an invalid input.
Your allowed to guess numbers outside the min and max range. Might be helpful to make those invaid inputs also
Code runs, but is a bit over complicated. Only the variables needed to change. 
Good job setting the max's to +1 over what they have to be. 
Great work with all the validation. 
*/

Console.Clear();
string playAgain;

do
{
    //asking user to select mode
    Console.WriteLine("Welcome to Guess It. Can you guess my number?");
    Console.Write("Enter a number to select a mode: 1 = Easy, 2 = Medium, 3 = Hard, 4 = Custom: ");
    string mode = Console.ReadLine();

    //validation for mode choice
    bool success = int.TryParse(mode, out int chooseMode);

    while (success == false || chooseMode >= 5 || chooseMode == 0)
    {
        Console.WriteLine("You did not enter a valid number.");
        Console.Write("Please enter a number 1 - 4: ");
        mode = Console.ReadLine();
        success = int.TryParse(mode, out chooseMode);
    }

    //intializing our object
    Random rand = new Random();
    //initialize min
    int min = 1;
    //declare variables
    string userNum;
    int playerGuess;
    int attempts = 1;



    //choose mode 1
    int max = 11;
    //this generates our random number between 1-10
    int randNum = rand.Next(min, max);

    while (chooseMode == 1)
    {
        // Console.WriteLine(randNum); //comment this out later

        Console.Write("Pick a number 1 - 10. Enter your guess here: ");
        userNum = Console.ReadLine();

        //validation
        bool success2 = int.TryParse(userNum, out playerGuess);

        //while loop to validate a number is entered
        while (success2 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success2 = int.TryParse(userNum, out playerGuess);
        }

        //if else statement to compare playerGuess with randNum
        if (success2)
        {
            if (randNum == playerGuess)
            {
                Console.WriteLine("Congrats! You got it right!");
                Console.WriteLine($"It took you {attempts} tries.");
                chooseMode = 0;
            }
            else if (randNum > playerGuess)
            {
                Console.WriteLine("Your guess is lower than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your guess is higher than my number");
                Console.WriteLine("Keep guessing.");
                // userNum = Console.ReadLine();
            }
            attempts = attempts + 1;
        }
    }

    //choose mode 2
    int max2 = 51;
    //this generates our random number between 1-50
    int randNum2 = rand.Next(min, max2);

    while (chooseMode == 2)
    {
        // Console.WriteLine(randNum2); //comment this out later

        Console.Write("Pick a number 1 - 50. Enter your guess here: ");
        userNum = Console.ReadLine();

        //validation
        bool success3 = int.TryParse(userNum, out playerGuess);

        //while loop to validate a number is entered
        while (success3 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success3 = int.TryParse(userNum, out playerGuess);
        }

        //if else statement to compare playerGuess with randNum
        if (success3)
        {
            if (randNum2 == playerGuess)
            {
                Console.WriteLine("Congrats! You got it right!");
                Console.WriteLine($"It took you {attempts} tries.");
                chooseMode = 0;
            }
            else if (randNum2 > playerGuess)
            {
                Console.WriteLine("Your guess is lower than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your guess is higher than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }

            attempts = attempts + 1;
        }
    }

    //choose mode 3
    int max3 = 101;
    //this generates our random number between 1-50
    int randNum3 = rand.Next(min, max3);

    while (chooseMode == 3)
    {
        // Console.WriteLine(randNum3); //comment this out later

        Console.Write("Pick a number 1 - 100. Enter your guess here: ");
        userNum = Console.ReadLine();

        //validation
        bool success4 = int.TryParse(userNum, out playerGuess);

        //while loop to validate a number is entered
        while (success4 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success4 = int.TryParse(userNum, out playerGuess);
        }

        //if else statement to compare playerGuess with randNum
        if (success4)
        {
            if (randNum3 == playerGuess)
            {
                Console.WriteLine("Congrats! You got it right!");
                Console.WriteLine($"It took you {attempts} tries.");
                chooseMode = 0;
            }
            else if (randNum3 > playerGuess)
            {
                Console.WriteLine("Your guess is lower than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your guess is higher than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }

            attempts = attempts + 1;
        }
    }


    //choose mode 4
    int min2 = 0;
    int max4 = 0;
    //this generates our random custom number

    while (chooseMode == 4)
    {

        Console.Write("Please enter your minimum number: ");
        string userMin = Console.ReadLine();
        bool success5 = int.TryParse(userMin, out min2);

        //validation

        //while loop to validate a number is entered
        while (success5 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success5 = int.TryParse(userNum, out min2);
        }

        Console.Write("Please enter your maximum number: ");
        string userMax = Console.ReadLine();
        bool success6 = int.TryParse(userMax, out max4);

        while (success6 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success6 = int.TryParse(userNum, out max4);
        }
        break;
    }

    int randNum4 = rand.Next(min2, max4);
    while (chooseMode == 4)
    {

        Console.Write($"Please enter a number between {min2} and {max4}: ");

        userNum = Console.ReadLine();

        // Console.WriteLine(randNum4); //comment this out later
        bool success7 = int.TryParse(userNum, out playerGuess);

        //validation
        while (success7 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please try again: ");
            userNum = Console.ReadLine();
            success7 = int.TryParse(userNum, out playerGuess);

        }
        //if else statement to compare playerGuess with randNum
        if (success7)
        {
            if (randNum4 == playerGuess)
            {
                Console.WriteLine("Congrats! You got it right!");
                Console.WriteLine($"It took you {attempts} tries.");
                chooseMode = 0;
            }
            else if (randNum4 > playerGuess)
            {
                Console.WriteLine("Your guess is lower than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your guess is higher than my number");
                Console.WriteLine("Keep guessing");
                // userNum = Console.ReadLine();
            }

            attempts = attempts + 1;
        }

    }

    // PLAY AGAIN?
    Console.WriteLine("Do you want to play again? Y / N ");
    playAgain = Console.ReadLine().ToUpper();

    while (playAgain != "Y" && playAgain != "N")
    {
        Console.WriteLine("Invalid input. Please enter Y / N ");
        playAgain = Console.ReadLine().ToUpper();
    }
    Console.WriteLine("Thank you for playing!");
} while (playAgain == "Y");
