//simple C# for loop
for (int m = 5; m <= 30; m+=5)
{
    Console.WriteLine(m);
}

//simple C# foreach loop
Console.WriteLine();

string[] states = ["Tennessee", "Florida", "California", "New Mexico", "Arizona", "Ohio", "Indiana"];

foreach (string s in states)
{
    Console.WriteLine(s);
}

//simple C# while loop
Console.WriteLine();

int o = 2;

while (o <= 100)
{
    Console.WriteLine(o);
    o *= 2;
}

//simple C# do-while loop
Console.WriteLine();

int f = 2;

do  
{
    Console.WriteLine(f);
    f *= 2;
} 
while (f <= 100);

//C# infinite loop
Console.WriteLine();

while (true)
{
    Console.WriteLine("Michael's Programming Bytes");
}

//C# nested loop
Console.WriteLine();

for (int t = 2; t <= 20; t*=2)
{
    for (int n = 5; n <= 30; n+=5)
    {
        Console.WriteLine(t * n);
    }
}