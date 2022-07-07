class Program {
    public static void Main(string[] args) {
        // Creating a simple monad with "Hello World" value...
        Monad<string> monad = new Monad<string>("Hello World");
        // Output: Hello World
        Console.WriteLine(monad.Value);

        string welcomeToMyWorld = "Welcome to my world";
        // This monad will convert 'welcomeToMyWorld' to uppercase
        string? welcomeToMyWorldUpperCase = new Monad<string>(welcomeToMyWorld)
            .Bind<string>((welcomeToMyWorld) => welcomeToMyWorld.ToUpper())
            .Value;
        // Output: WELCOME TO MY WORLD
        Console.WriteLine(welcomeToMyWorldUpperCase);

        string numberInString = "1023";
        // This monad will convert 1023 string to 1023 integerr
        int? number = new Monad<string>(numberInString)
            .Bind<int>((numberInString) => int.Parse(numberInString))
            .Value;
        // Output: 1023
        Console.WriteLine(number);

        // Empty Test...
        string letters = "abcdeghijklmon";
        // Getting first letter that is uppercase
        bool emptyFirstUpperCaseLetter = new Monad<string>(letters)
            .Bind<string[]>((letters) => letters.Split(""))
            .Bind<string>((letters) => letters.FirstOrDefault(letter => letter == letter.ToUpper()))
            .IsEmpty;
        // Output: true
        Console.WriteLine(emptyFirstUpperCaseLetter);
    }
}