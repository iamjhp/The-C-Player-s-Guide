using _28_Room_Coordinates;

Coordinate a = new Coordinate(3, 3);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(2, 2);

Console.WriteLine(Coordinate.IsAdjacent(a, b)); // Should be True
Console.WriteLine(Coordinate.IsAdjacent(b, c)); // Should be True
Console.WriteLine(Coordinate.IsAdjacent(a, c)); // Should be False