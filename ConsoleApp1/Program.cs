Console.Write("What is your name? ");
string userInput = Console.ReadLine();
Console.WriteLine("Hello, " + userInput);
bool isAgain = true;
do
{
    Console.WriteLine("Please entere a number between 1 and 100. ");
    string number = Console.ReadLine();
    int num = int.Parse(number);
    if (num % 2 != 0 && num > 0 && num <= 60)
    {
        Console.WriteLine("Odd number less than 60. ");
    }
    else if (num % 2 == 0 && num >= 2 && num < 25)
    {
        Console.WriteLine("Even number less than 25");
    }
    else if (num % 2 == 0 && num >= 26 & num < 60)
    {
        Console.WriteLine("Even number between 26 and 60");
    }
    else if (num % 2 == 0 && num > 60 && num <= 100)
    {
        Console.WriteLine(" Even number greater than 60");
    }
    else
    {
        Console.WriteLine("odd number greater than 60");
    }
    Console.WriteLine("Would you like to enter another number? (Y/N)");
    string anotherNumber = Console.ReadLine();
    if (anotherNumber == "yes" || anotherNumber == "y")
    {

    }
    else
    {
        Console.WriteLine("Thank you, have a great day " + userInput);
        break;
    }


} while (isAgain == true);

