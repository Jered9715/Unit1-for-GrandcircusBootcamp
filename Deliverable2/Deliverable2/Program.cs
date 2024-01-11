//Deliverable 2 Coin FLip Challenge

internal class Program
{
    public static void Main(string[] args)
    {
        //Establishing user variables
        string userName = string.Empty;
        string userAnswer = string.Empty;
        string challengeAnswer = string.Empty;
        int score = 0;

        //Welcome greeting and request for username
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        Console.Write(">");
        userName = Console.ReadLine();

        //added for spacing in console
        Console.WriteLine();

        //Proposition of challenge

        Console.WriteLine("Welcome " + userName + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        Console.Write(">");
        challengeAnswer = Console.ReadLine();
        challengeAnswer = challengeAnswer.ToLower();

        //added for spacing in console
        Console.WriteLine();

        //Beginning If Else for acceptance or decline of challenge
        if (challengeAnswer == "yes")
        {
            //creating loop to allow for Rounds
            for (int round = 0; round < 5; round++)
            {
                //this is to make the randomized flip for comparing
                Random rnd = new Random();
                int coin = rnd.Next(0, 2);

                //determining value of 0 and 1


                //ask user for answer to coin flip
                Console.WriteLine("Heads or Tails?");
                Console.Write(">");
                userAnswer = Console.ReadLine();
                userAnswer = userAnswer.ToLower();

                //comparison of user answer of heads or tail to coin flip value
                //asign score based on correct answer
                //Heads = 1
                //Tails = 0
                if (userAnswer == "heads")
                {
                    if (coin == 1)
                    {
                        Console.WriteLine("Correct!");
                        score++;

                        //added for spacing in console
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");

                        //added for spacing in console
                        Console.WriteLine();
                    }
                }
                else if (userAnswer == "tails")
                {
                    if (coin == 0)
                    {
                        Console.WriteLine("Correct!");
                        score++;

                        //added for spacing in console
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");

                        //added for spacing in console
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Answer not recognized, no points given :( ");
                    //added for spacing in console
                    Console.WriteLine();
                }



            }

            // End of game summary
            Console.WriteLine("Thank you " + userName + ", you got a score of " + score + "!");
        }
        else if (challengeAnswer == "no")
        {
            Console.WriteLine("You are a coward " + userName);
        }
        else
        {
            Console.WriteLine("Answer not recognized, please restart the game.");
        }
    }
}