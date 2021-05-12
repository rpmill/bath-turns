using System;


namespace BathTurns
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            string welcomeMessage = "Who's going first for bathes? Pick any number between 1 and 10. Ready?...";
            string userInput = "";
            int randomNumber = 0;

            Console.WriteLine(welcomeMessage);
            userInput = Console.ReadLine();           
                  
            if(userInput.ToUpper().Equals("YES"))
            {
                while(userInput.ToUpper().Equals("YES"))
                {
                    randomNumber = RandomNumber.RandomNumberGenerator(1,10);
                    Console.WriteLine("The number is " + randomNumber.ToString());
                    Console.WriteLine("Do you wish to play again?...");
                    userInput = Console.ReadLine();

                    if(userInput.ToUpper().Equals("NO"))
                    {
                        break;
                    }
                }               

            }      


        }

    }
}
