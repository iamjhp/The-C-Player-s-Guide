using ArrowFactories;

Console.WriteLine("What arrow do you want to buy?");
Console.WriteLine("1 - Custom Arrow");
Console.WriteLine("2 - Elite Arrow");
Console.WriteLine("3 - Beginner Arrow");
Console.WriteLine("4 - Marksman Arrow");

string input = Console.ReadLine();

Arrow arrow = input switch {
    "1" => CreateCustomArrow(),
    "2" => Arrow.CreateEliteArrow(),
    "3" => Arrow.CreateBeginnerArrow(),
    "4" => Arrow.CreateMarksmanArrow()
};

Console.WriteLine($"That arrow costs {arrow.Cost} gold.");

Arrow CreateCustomArrow() {
    ArrowHead arrowHead = GetArrowHeadType();
    Fletching flecthing = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowHead, flecthing, length);
}

ArrowHead GetArrowHeadType() {
    Console.Write("Choose arrowhead type (steel, wood, obsidian) ");
    string input = Console.ReadLine();

    return input switch {
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian
    };
}

Fletching GetFletchingType() {
    Console.Write("Choose fletching type (plastic, turkey feather, goose feather) ");
    string input = Console.ReadLine();

    return input switch {
        "plastic" => Fletching.Plastic,
        "turkey feather" => Fletching.TurkeyFeathers,
        "goose feather" => Fletching.GooseFeathers
    };
}

float GetLength() {
    float length;

    do {
        Console.Write("Choose arrow length between 60 and 100: ");
        length = Convert.ToSingle(Console.ReadLine());
    } while (length < 60 || length > 100);

    return length;
}

