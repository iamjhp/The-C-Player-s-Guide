using ThePasswordValidator;

PasswordValidator validator = new PasswordValidator();

while (true) {
    Console.WriteLine("Enter a password:");
    string? password = Console.ReadLine();

    if (password == "" || password == null) break;

    if (validator.IsValid(password)) Console.WriteLine("Your password is valid");
    else Console.WriteLine("Invalid password");
    Console.WriteLine("");
}