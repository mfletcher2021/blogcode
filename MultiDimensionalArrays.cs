// Simple 2-dimensional array
int[,] years = { { 2018, 2020, 2022, 2024 }, { 2019, 2021, 2023, 2025 } };

//accessing element of array
Console.WriteLine(years[0, 2]);

Console.WriteLine();

//modifying the fourth element in the second nested array
years[1, 3] = 2027;
Console.WriteLine(years[1, 3]);

Console.WriteLine();

//finding the length of the array
Console.WriteLine(years.Length);