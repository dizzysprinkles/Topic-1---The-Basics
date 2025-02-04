namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string firstName, favMovie, favQuote;
            firstName = "Zoey";
            favMovie = "The Matrix";
            favQuote = "I'll be back"; //Need to find movie/show/song quote...

            //Part 1
            Console.WriteLine($"hey {firstName.ToLower()}! i like the movie {favMovie.ToLower()}.");
            Console.WriteLine();

            favMovie = favMovie.ToUpper();
            Console.WriteLine($"{favMovie} RULES!");
            Console.WriteLine();
            Console.WriteLine($"True or False: {favMovie} contains a THE? {favMovie.Contains("THE")}");
            Console.WriteLine();

            Console.WriteLine($"This is a funky way of spelling {favMovie}: {favMovie.Replace("A", "@").Replace("E", "3")}");

            //Part 2
            Console.WriteLine($"My favourite movie quote is from the terminator and it's: {favQuote}");//Print quote then remove all the vowels and replace them with an empty string and reprint
            favQuote = favQuote.ToLower();
            Console.WriteLine($"...I actually hate vowels. The new quote is: {favQuote.Replace("i", " ").Replace("e", " " ).Replace("a", " ")}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here's some ASCII art featuring Piglet, Eeyore, and Winnie the Pooh!");

            //Part 3 - ASCII Art
            Console.WriteLine("        _       ,~~--~~-.              _");
            Console.WriteLine("      _<_/_    +      | |\\           _( )_");
            Console.WriteLine("   __/    _>   || |~ |`,/-\\         (     (o__");
            Console.WriteLine("  '\\  '  |     *\\_) \\_) `-'        |       _ 7");
            Console.WriteLine("    \\___/                           \\     (\")");
            Console.WriteLine("    /+++\\                           /      \\ \\");
            Console.WriteLine(" o=|..|..|                          |     \\ __/");
            Console.WriteLine("   | o/..|                          |        |");
            Console.WriteLine("0==|+++++|                          (       /");
            Console.WriteLine(" 0======/                            \\     /");
            Console.WriteLine("                                      )   /(_");
            Console.WriteLine("                                      |  (___)");
            Console.WriteLine("                                      \\___)");

        }
    }
}
