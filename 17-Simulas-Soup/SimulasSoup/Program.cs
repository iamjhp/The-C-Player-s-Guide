// See https://aka.ms/new-console-template for more information

using SimulasSoup;

SoupType type = SoupType.Soup;

(SoupType soupTye, MainIngredient mainIngredient, Seasoning seasoning) soup = (GetSoupType(), GetMainIngredient(), GetSeasoning());
Console.WriteLine($"{soup.seasoning} {soup.mainIngredient} {soup.soupTye}");


SoupType GetSoupType() {
    Console.Write("Choose soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine();

    return input switch {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo
    };
}

MainIngredient GetMainIngredient() {
    Console.Write("Choose main ingredient (mushroom, chicken, carrot, potato): ");
    string input = Console.ReadLine();

    return input switch {
        "mushroom" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrot" => MainIngredient.Carrot,
        "potato" => MainIngredient.Potato
    };
}

Seasoning GetSeasoning() {
    Console.Write("Choose seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();

    return input switch {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}
