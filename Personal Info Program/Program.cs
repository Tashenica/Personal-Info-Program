// See https://aka.ms/new-console-template for more

string name = "Tashenica";
int age = 25;
string city = "Cape Town";
int currentYear = 2025;
int yearBorn = currentYear - age;

Console.WriteLine($"My name is {name.ToUpper()}, I am {age} years old and I stay in {city}.");
Console.WriteLine($"I was born in the year {yearBorn}.");
