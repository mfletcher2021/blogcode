class NewCat
{
    string color;
    int age;
    string gender;

    public NewCat(string catColor, int catAge, string catGender)
    {
        color = catColor;
        age = catAge;
        gender = catGender;
    }

    static void Main(string[] args)
    {
        NewCat brownCat = new NewCat("brown", 11, "female");
        Console.WriteLine("This is a " + brownCat.color + " cat who is " + brownCat.age + " years old and is a " + brownCat.gender);

    }
}