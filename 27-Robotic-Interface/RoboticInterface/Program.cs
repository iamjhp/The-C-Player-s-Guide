using RoboticInterface;

Robot robot = new Robot();

for (int i = 0; i < 3; i++) {
    Console.Write("Enter on, off, north, south, east or west: ");
    string? input = Console.ReadLine();

    IRobotCommand newCommand = input switch {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand()
    };

    robot.Commands[i] = newCommand;
}

robot.Run();