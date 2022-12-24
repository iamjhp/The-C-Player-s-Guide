using PackingInventory;

Pack pack = new Pack(5, 5, 7);

while (true) {
    Console.WriteLine($"Pack information: {pack.CurrCount}/{pack.MaxCount} items, {pack.CurrWeight}/{pack.MaxWeight} weight, {pack.CurrVolume}/{pack.MaxVolume} volume");

    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");

    int input = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = input switch {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    if (!pack.Add(newItem))
        Console.WriteLine("Could not add your item to the pack");
}
