Console.WriteLine("1. Enter a number less than 10");
Console.WriteLine("2. Ask 'Do you want to continue?' three times");
Console.WriteLine("Choose: 1 or 2");

int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    int number;
    do
    {
        Console.Write("Enter a number less than 10: ");
        number = int.Parse(Console.ReadLine());

        if (number >= 10)
        {
            Console.WriteLine("The number must be less than 10. Try again.");
        }
    }
    while (number >= 10);

    Console.WriteLine("You entered: " + number);
}
else if (choice == 2)
{
    int yesCount = 0;
int noCount = 0;
string answer;

do
{
    Console.Write("Do you want to continue? (Yes/No): ");
    answer = Console.ReadLine().Trim().ToLower();

    if (answer == "yes")
    {
        yesCount++;
        Console.WriteLine("You have answered 'Yes' " + yesCount + " time(s).");
    }
    else if (answer == "no")
    {
        noCount++;
        Console.WriteLine("You have answered 'No' " + noCount + " time(s).");
    }
    else
    {
        Console.WriteLine("Invalid input. Please answer 'Yes' or 'No'.");
        continue;
    }

} while (yesCount < 3 && noCount < 3);

if (yesCount == 3)
{
    Console.WriteLine("Action completed with 3 'Yes' responses.");
}
else if (noCount == 3)
{
    Console.WriteLine("Action stopped with 3 'No' responses.");
}
}
else
{
    Console.WriteLine("Invalid choice.");
}