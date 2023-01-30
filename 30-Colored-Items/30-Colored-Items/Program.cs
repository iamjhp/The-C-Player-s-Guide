ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();

public class ColoredItem<T> {

    public T Item { get; }
    public ConsoleColor Color { get; }


    public ColoredItem(T item, ConsoleColor color) {
        this.Item = item;
        this.Color = color;
    }

    public void Display() {
        Console.BackgroundColor = Color;
        Console.WriteLine(Item);
    }
}


public class Sword { }
public class Bow { }
public class Axe { }