using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        const string MsgExercise = "Choose an option\n" +
            "1 - Parking\n" +
            "0 - Exit";
        const string Error = "Invalid Input, please enter a 1 or a 0";
        const string Exit = "Exiting...";
        const string Wolf = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠁⠸⢳⡄⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠃⠀⠀⢸⠸⠀⡠⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠃⠀⠀⢠⣞⣀⡿⠀⠀⣧⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡖⠁⠀⠀⠀⢸⠈⢈⡇⠀⢀⡏⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠩⢠⡴⠀⠀⠀⠀⠀⠈⡶⠉⠀⠀⡸⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⠎⢠⣇⠏⠀⠀⠀⠀⠀⠀⠀⠁⠀⢀⠄⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢠⠏⠀⢸⣿⣴⠀⠀⠀⠀⠀⠀⣆⣀⢾⢟⠴⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢀⣿⠀⠠⣄⠸⢹⣦⠀⠀⡄⠀⠀⢋⡟⠀⠀⠁⣇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢀⡾⠁⢠⠀⣿⠃⠘⢹⣦⢠⣼⠀⠀⠉⠀⠀⠀⠀⢸⡀⠀⠀⠀⠀\r\n⠀⠀⢀⣴⠫⠤⣶⣿⢀⡏⠀⠀⠘⢸⡟⠋⠀⠀⠀⠀⠀⠀⠀⠀⢳⠀⠀⠀⠀\r\n⠐⠿⢿⣿⣤⣴⣿⣣⢾⡄⠀⠀⠀⠀⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀\r\n⠀⠀⠀⣨⣟⡍⠉⠚⠹⣇⡄⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠀⠀⢀⡀⣾⡇⠀⠀\r\n⠀⠀⢠⠟⣹⣧⠃⠀⠀⢿⢻⡀⢄⠀⠀⠀⠀⠐⣦⡀⣸⣆⠀⣾⣧⣯⢻⠀⠀\r\n⠀⠀⠘⣰⣿⣿⡄⡆⠀⠀⠀⠳⣼⢦⡘⣄⠀⠀⡟⡷⠃⠘⢶⣿⡎⠻⣆⠀⠀\r\n⠀⠀⠀⡟⡿⢿⡿⠀⠀⠀⠀⠀⠙⠀⠻⢯⢷⣼⠁⠁⠀⠀⠀⠙⢿⡄⡈⢆⠀\r\n⠀⠀⠀⠀⡇⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠦⠀⠀⠀⠀⠀⠀⡇⢹⢿⡀\r\n⠀⠀⠀⠀⠁⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠼⠇⠁";
        const string Key = "Press any key to continue";
        const string Longumber = "Enter a natural long number (1 digit min and 8 max): ";
        const string SumEven = "The sum of all number in a even position is: {0}.";
        const string MultiOdd = "The product of all number in a odd position is: {0}.";
        const string MsgMaxMin = "The higher number is: {0}, and the lower number is: {1}.";
        int numbers = 0, sum, multi, higher, lower, op = -1;
        string stringNumbers = "";

        do
        {
            try
            {
                Console.WriteLine(MsgExercise);
                Console.ForegroundColor = ConsoleColor.Green;
                op = Int32.Parse(Console.ReadLine() ?? "-1");
                Console.ForegroundColor = ConsoleColor.White;
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
                        numbers = validateInput(Longumber);
                        stringNumbers = numbers.ToString();
                        sum = SumPar(stringNumbers);
                        Console.WriteLine(SumEven, sum);
                        multi = ProdOdd(stringNumbers);
                        Console.WriteLine(MultiOdd, multi);
                        higher = 0;
                        lower = 9;
                        MaxMin(stringNumbers, ref higher, ref lower);
                        Console.WriteLine(MsgMaxMin, higher, lower);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Key);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Error);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Error);
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (op != 0);
    }
    public static int validateInput(string text)
    {
        int value;
        do
        {
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Green;
        } while (!Int32.TryParse(Console.ReadLine(), out value));
        Console.ForegroundColor = ConsoleColor.White;
        return value;
    }
    public static int SumPar(string text)
    {
        int count = 1, sum = 0, num;
        foreach (char word in text)
        {
            if (count % 2 == 0)
            {
                num = int.Parse(word.ToString());
                sum += num;
            }
            count++;
        }
        return sum;
    }
    public static int ProdOdd(string text)
    {
        int count = 1, multi = 1, num;
        foreach (char word in text)
        {
            if (count % 2 != 0)
            {
                num = int.Parse(word.ToString());
                multi *= num;
            }
            count++;
        }
        return multi;
    }
    public static void MaxMin(string text, ref int max, ref int min)
    {
        int count = 1, num;
        foreach (char word in text)
        {
            num = int.Parse(word.ToString());
            if (num < min)
            {
                min = num;
            }
            else if (num > max)
            {
                max = num;
            }
            count++;
        }
    }
}