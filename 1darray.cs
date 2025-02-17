//Simple C# array example
string[] languages = ["Python", "R", "Java", "MySQL", "CSS", "Bootstrap", "HTML", "C#", "GitHub"];

Console.WriteLine(languages[2]);

//sorting array alphabetically
Array.Sort(languages);
Console.WriteLine();

foreach (string l in languages)
    {
    Console.WriteLine(l);
}

//reverse sorting array
Console.WriteLine();
Array.Reverse(languages);

foreach (string l in languages)
{
    Console.WriteLine(l);
}

//modifying an array
Console.WriteLine();
languages[1] = "JavaScript";
Console.WriteLine(string.Join(", ", languages));

//how long is the array
Console.WriteLine();
Console.WriteLine(languages.Length);