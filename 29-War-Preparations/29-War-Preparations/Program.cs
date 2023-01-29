using _29_War_Preparations;

Sword basicSword = new Sword(Material.Iron, Gemstone.None, 5.0, 3.0);
Sword woodenSword = basicSword with { Material = Material.Wood };
Sword steelSword = basicSword with { Material = Material.Steel, Gemstone = Gemstone.Diamond, Length = 6.0 };

Console.WriteLine(basicSword);
Console.WriteLine( woodenSword);
Console.WriteLine(steelSword);
