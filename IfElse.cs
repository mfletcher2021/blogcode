// Program to test if-else statements using American grading system example (example 1 in blog)
//Console.WriteLine("Pick a number between 0 and 100");
//String userNumber = Console.ReadLine();
//int userNumberInt = int.Parse(userNumber);
//String grade = "";

//if (userNumberInt >= 70 | userNumberInt <= 100)
//{
//    grade = "pass";
//}
//else
//{
//    grade = "fail";
//}

//Console.WriteLine("Your grade is a " + grade);

//How to write nested if-else statements using same American grading system example (example 2 in blog)
Console.WriteLine("Pick a number between 0 and 100");
String userNumber = Console.ReadLine();
int userNumberInt = int.Parse(userNumber);
String grade = "";

if (userNumberInt >= 90 & userNumberInt <= 100)
{
    if (userNumberInt >= 97 & userNumberInt <= 100)
    {
        grade = "A+";
    }
    else if (userNumberInt >= 93 & userNumberInt <= 96)
    {
        grade = "A";
    }
    else
    {
        grade = "A-";
    }
}

else if (userNumberInt >= 80 & userNumberInt <= 89)
{
    if (userNumberInt >= 87 & userNumberInt <= 89)
    {
        grade = "B+";
    }
    else if (userNumberInt >= 83 & userNumberInt <= 86)
    {
        grade = "B";
    }
    else
    {
        grade = "B-";
    }
}

else if (userNumberInt >= 70 & userNumberInt <= 79)
{
    if (userNumberInt >= 77 & userNumberInt <= 79)
    {
        grade = "C+";
    }
    else if (userNumberInt >= 73 & userNumberInt <= 76)
    {
        grade = "C";
    }
    else
    {
        grade = "C-";
    }
}

else if (userNumberInt >= 60 & userNumberInt <= 69)
{
    if (userNumberInt >= 67 & userNumberInt <= 69)
    {
        grade = "D+";
    }
    else if (userNumberInt >= 63 & userNumberInt <= 66)
    {
        grade = "D";
    }
    else
    {
        grade = "D-";
    }
}

else
{
    grade = "F";
}

Console.WriteLine("Your grade is a " + grade);