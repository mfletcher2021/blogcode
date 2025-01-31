//Demonstrating switch statements using IGN rating system as an example
Console.WriteLine("Pick a number between 0 and 10");
String score = Console.ReadLine();
int scoreInt = int.Parse(score);
String review = "";

switch (scoreInt)
{
    case 0:
        Console.WriteLine("Unbearable");
        break;
    case 1:
        Console.WriteLine("Unbearable");
        break;
    case 2:
        Console.WriteLine("Painful");
        break;
    case 3:
        Console.WriteLine("Awful");
        break;
    case 4:
        Console.WriteLine("Bad");
        break;
    case 5:
        Console.WriteLine("Mediocre");
        break;
    case 6:
        Console.WriteLine("Okay");
        break;
    case 7:
        Console.WriteLine("Good");
        break;
    case 8:
        Console.WriteLine("Great");
        break;
    case 9:
        Console.WriteLine("Amazing");
        break;
    case 10:
        Console.WriteLine("Masterpiece");
        break;
}
