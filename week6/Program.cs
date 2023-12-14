

string[] FruitBasket = { "Apples", "Bananas", "Oranges" };

Console.WriteLine($"There are {FruitBasket.Length} fruit in basket.");

//Console.WriteLine(FruitBasket[0]);
//Console.WriteLine(FruitBasket[1]);
//Console.WriteLine(FruitBasket[2]);

for (int i = 0; i < FruitBasket.Length; i++)
{
    Console.WriteLine(FruitBasket[i]);
}

FruitBasket[0] = "Pine-apple";
FruitBasket[2] = "Peaches";

//Console.WriteLine(FruitBasket[0]);
//Console.WriteLine(FruitBasket[1]);
//Console.WriteLine(FruitBasket[2]);

for (int i = 0; i < FruitBasket.Length; i++)
{
    Console.WriteLine(FruitBasket[i]);
}

