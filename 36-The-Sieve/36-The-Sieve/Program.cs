
using System.Xml.Serialization;
using _36_The_Sieve;

Console.WriteLine("Choose 1=even, 2=positive or 3=multipleOfTen Filter");
int input = int.Parse(Console.ReadLine());

Sieve sieve = input switch {
    1 => new Sieve(IsEven),
    2 => new Sieve(IsPositive),
    3 => new Sieve(IsMultiplesOfTen)
};

while (true) {
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    string goodOrBad = sieve.IsGood(number) ? "good" : "bad";
    Console.WriteLine(goodOrBad);
}

bool IsEven(int number) => number % 2 == 0;
bool IsPositive(int number) => number > 0;
bool IsMultiplesOfTen(int number) => number % 10 == 0;