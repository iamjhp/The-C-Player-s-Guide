// See https://aka.ms/new-console-template for more information
using SimulaTest;

ChestStateEnum currState = ChestStateEnum.Locked;

while (true) {
    Console.Write($"The chest is {currState.ToString().ToLower()}. What do you want to do? ");

    string userInput = Console.ReadLine();

    if (currState == ChestStateEnum.Open && userInput == "close") currState = ChestStateEnum.Closed;
    if (currState == ChestStateEnum.Closed && userInput == "lock") currState = ChestStateEnum.Locked;
    if (currState == ChestStateEnum.Closed && userInput == "open") currState = ChestStateEnum.Open;
    if (currState == ChestStateEnum.Locked && userInput == "unlock") currState = ChestStateEnum.Closed;
}
