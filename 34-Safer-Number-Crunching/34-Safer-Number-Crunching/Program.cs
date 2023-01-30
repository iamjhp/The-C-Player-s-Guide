int intNumber;

do {
    Console.WriteLine("Enter an integer");
} while (!int.TryParse(Console.ReadLine(), out intNumber));
Console.WriteLine(intNumber);

double doubleNumber;
do {
    Console.WriteLine("Enter a number");
} while (!double.TryParse(Console.ReadLine(), out doubleNumber));
Console.WriteLine(doubleNumber);

bool enteredBool;
do {
    Console.WriteLine("Enter true or false");
} while (!bool.TryParse(Console.ReadLine(), out enteredBool));
Console.WriteLine(enteredBool);
