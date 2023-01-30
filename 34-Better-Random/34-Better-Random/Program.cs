using _34_Better_Random;

Random random = new Random();

Console.WriteLine(random.NextDouble(100));
Console.WriteLine(random.NextString("up", "down", "left", "right"));
Console.WriteLine(random.CoinFlip());
Console.WriteLine(random.CoinFlip(0.25));
