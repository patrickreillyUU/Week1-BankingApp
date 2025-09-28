/* 
 * *Class name: Banking App
 * Version 1 
 * Author: Patrick Reilly
 */

void BuildBankingApp()
{
    //Display the main menu screen. 
    int choice;
    int depositOrWithdraw;
    double depositAmount;
    double withdrawAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    //Read user choice menu choice. 
    //Convert the string to an integer.
    //Using explicit typecasting.

    choice = Convert.ToInt32(Console.ReadLine());

    //The || in the loop represents OR 
    //Which means that a menu choice of 1 OR 2 
    // is accepted for this logical operartion
    if (choice == 1 || choice == 2)
    {
        //Valid menu choice 
        if (choice == 1)
        {
            //Deposit or withdraw funds 
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("3 - deposit");
            Console.WriteLine("4 - withdraw");
            Console.WriteLine("Please choose an option (3-4)");
            depositOrWithdraw = Convert.ToInt32(Console.ReadLine());

            if (depositOrWithdraw == 3)
            {
                Console.WriteLine("How much do you want to deposit?");
                Console.WriteLine("Enter the amount including pence using a decimal point");

                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                accountBalance += depositAmount;
                Console.WriteLine($"Your new account balance is {accountBalance}");
            }
            else if (depositOrWithdraw == 4)
            {
                Console.WriteLine("How much do you want to withdraw?");
                Console.WriteLine("Enter the amount including pence using a decimal point");

                withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                if (accountBalance > withdrawAmount)
                {
                    accountBalance -= withdrawAmount;
                    Console.WriteLine($"Your new account balance is {accountBalance}");
                }
                else if (withdrawAmount > accountBalance)
                { 
                    Console.WriteLine("You have insufficient funds to withdraw this amount");
                }
                 
            }
            else
            {
                //Invalid menu choice
                Console.WriteLine("Invalid choice, please choose 3 or 4");
            }
        }
        if (choice == 2)
        {
            //View current qccount information 
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            //View current account info
            accountBalance = 1000.00;
            Console.WriteLine("You have chosen to view current account information");
        }
        
        
    }
    else
    {
        //Invalid menu choice 
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();
