//creating a Cat class
class Cat
{
    string color = "orange";
    int age = 11;
    string gender = "male";

    static void Main(string[] args)
    {
        Cat orangeCat = new Cat();
        Console.WriteLine(orangeCat.age);

    }
}