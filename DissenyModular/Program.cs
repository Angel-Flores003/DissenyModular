using System;
using System.Linq.Expressions;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        const string MsgExercise = "Choose an option\n" +
            "1 - Value in range\n" +
            "0 - Exit";
        const string Error = "Invalid Input, please enter a number between 0 and 10";
        const string Exit = "Exiting...";
        const string Wolf = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠁⠸⢳⡄⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠃⠀⠀⢸⠸⠀⡠⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠃⠀⠀⢠⣞⣀⡿⠀⠀⣧⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡖⠁⠀⠀⠀⢸⠈⢈⡇⠀⢀⡏⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠩⢠⡴⠀⠀⠀⠀⠀⠈⡶⠉⠀⠀⡸⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⠎⢠⣇⠏⠀⠀⠀⠀⠀⠀⠀⠁⠀⢀⠄⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢠⠏⠀⢸⣿⣴⠀⠀⠀⠀⠀⠀⣆⣀⢾⢟⠴⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢀⣿⠀⠠⣄⠸⢹⣦⠀⠀⡄⠀⠀⢋⡟⠀⠀⠁⣇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢀⡾⠁⢠⠀⣿⠃⠘⢹⣦⢠⣼⠀⠀⠉⠀⠀⠀⠀⢸⡀⠀⠀⠀⠀\r\n⠀⠀⢀⣴⠫⠤⣶⣿⢀⡏⠀⠀⠘⢸⡟⠋⠀⠀⠀⠀⠀⠀⠀⠀⢳⠀⠀⠀⠀\r\n⠐⠿⢿⣿⣤⣴⣿⣣⢾⡄⠀⠀⠀⠀⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀\r\n⠀⠀⠀⣨⣟⡍⠉⠚⠹⣇⡄⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠀⠀⢀⡀⣾⡇⠀⠀\r\n⠀⠀⢠⠟⣹⣧⠃⠀⠀⢿⢻⡀⢄⠀⠀⠀⠀⠐⣦⡀⣸⣆⠀⣾⣧⣯⢻⠀⠀\r\n⠀⠀⠘⣰⣿⣿⡄⡆⠀⠀⠀⠳⣼⢦⡘⣄⠀⠀⡟⡷⠃⠘⢶⣿⡎⠻⣆⠀⠀\r\n⠀⠀⠀⡟⡿⢿⡿⠀⠀⠀⠀⠀⠙⠀⠻⢯⢷⣼⠁⠁⠀⠀⠀⠙⢿⡄⡈⢆⠀\r\n⠀⠀⠀⠀⡇⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠦⠀⠀⠀⠀⠀⠀⡇⢹⢿⡀\r\n⠀⠀⠀⠀⠁⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠼⠇⠁";
        const string Key = "Press any key to continue";        
        const string MsgInput = "Enter a number to validate: ";
        const string MaxRang = "Enter the maximum limit: ";
        const string MinRang = "Enter the minimum limit: ";
        const string InRange = "The number {0} is in range [{1},{2}]";
        const string OutRange = "The number {0} isn't in range [{1},{2}]";
        int value = 0, numMax = 0, numMin = 0,op = -1;

        do
        {
            try
            {
                Console.WriteLine(MsgExercise);
                op = Int32.Parse(Console.ReadLine() ?? "-1");
                switch (op)
                {
                    case 0:
                        Console.WriteLine(Exit);
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(Wolf);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 1:
                        numMin = validateInput(MinRang);
                        numMax = validateInput(MaxRang);
                        value = validateInput(MsgInput);
                        if (numMax < numMin)
                        {
                            Swap(ref numMax, ref numMin);
                        }
                        Console.WriteLine(isInRange(value, numMin, numMax) ? string.Format(InRange, value, numMin, numMax) : string.Format(OutRange, value, numMin, numMax));
                        Console.WriteLine(Key);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        } while (op != 0);
    }
    public static int validateInput(string text)
    {
        int value;
        do
        {
            Console.Write(text);
        } while (!Int32.TryParse(Console.ReadLine(), out value));
        return value;
    }
    public static void Swap(ref int max, ref int min)
    {
        int swap;
        if (max < min)
        {
            swap = max;
            max = min;
            min = swap;
        }
    }
    public static bool isInRange(int value, int min, int max) => value >= min && value <= max;
}