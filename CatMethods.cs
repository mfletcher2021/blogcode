using System.Net.NetworkInformation;

class Cat
{
    //setting initial values for attributes of Cat class
    string color = "orange";
    int age = 11;
    string gender = "male";

    static void meow()
        //setting up the static void meow() method
    {
        Console.WriteLine("meowmeowmeowmeow");
    }

    static void calculateHumanAge(int age)
        //setting up method to calculate cat's human age
    {
        Console.WriteLine("The cat is " + age * 7 + " in human years.");
    }
    
    static String nameBackwards(string name)
        //setting up method to print cat's name backwards
    {
        char[] nameList = name.ToCharArray();
        String reversedName = String.Empty;

        for (int i = nameList.Length - 1; i >= 0; i--)
        {
            reversedName += nameList[i];
        }

        return reversedName;
    }

    static void Main(string[] args)
    {
        //displaying all attributes and calling all methods
        Cat orangeCat = new Cat();
        Console.WriteLine(orangeCat.age);
        meow();
        meow();
        calculateHumanAge(11);
        Console.WriteLine(nameBackwards("Simba"));

    }
}