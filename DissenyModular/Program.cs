using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        const string MsgExercise = "Choose an option\n" +
            "1 - Change Temperature\n" +
            "0 - Exit";
        const string Error = "Invalid Input, please enter a 1 or a 0";
        const string Exit = "Exiting...";
        const string Wolf = "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠁⠸⢳⡄⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠃⠀⠀⢸⠸⠀⡠⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠃⠀⠀⢠⣞⣀⡿⠀⠀⣧⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡖⠁⠀⠀⠀⢸⠈⢈⡇⠀⢀⡏⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠩⢠⡴⠀⠀⠀⠀⠀⠈⡶⠉⠀⠀⡸⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⠎⢠⣇⠏⠀⠀⠀⠀⠀⠀⠀⠁⠀⢀⠄⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢠⠏⠀⢸⣿⣴⠀⠀⠀⠀⠀⠀⣆⣀⢾⢟⠴⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢀⣿⠀⠠⣄⠸⢹⣦⠀⠀⡄⠀⠀⢋⡟⠀⠀⠁⣇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢀⡾⠁⢠⠀⣿⠃⠘⢹⣦⢠⣼⠀⠀⠉⠀⠀⠀⠀⢸⡀⠀⠀⠀⠀\r\n⠀⠀⢀⣴⠫⠤⣶⣿⢀⡏⠀⠀⠘⢸⡟⠋⠀⠀⠀⠀⠀⠀⠀⠀⢳⠀⠀⠀⠀\r\n⠐⠿⢿⣿⣤⣴⣿⣣⢾⡄⠀⠀⠀⠀⠳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀\r\n⠀⠀⠀⣨⣟⡍⠉⠚⠹⣇⡄⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠀⠀⢀⡀⣾⡇⠀⠀\r\n⠀⠀⢠⠟⣹⣧⠃⠀⠀⢿⢻⡀⢄⠀⠀⠀⠀⠐⣦⡀⣸⣆⠀⣾⣧⣯⢻⠀⠀\r\n⠀⠀⠘⣰⣿⣿⡄⡆⠀⠀⠀⠳⣼⢦⡘⣄⠀⠀⡟⡷⠃⠘⢶⣿⡎⠻⣆⠀⠀\r\n⠀⠀⠀⡟⡿⢿⡿⠀⠀⠀⠀⠀⠙⠀⠻⢯⢷⣼⠁⠁⠀⠀⠀⠙⢿⡄⡈⢆⠀\r\n⠀⠀⠀⠀⡇⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠦⠀⠀⠀⠀⠀⠀⡇⢹⢿⡀\r\n⠀⠀⠀⠀⠁⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠼⠇⠁";
        const string Key = "Press any key to continue";
        const string EnterTemp = "Enter a decimal temperature: ";
        const string TypeConvert = "1: Celsius a Fahrenheit\n" +
            "2: Fahrenheit a Celsius\n" +
            "3: Celsius a Kelvin";
        const string NoAttempts = "Run ount of attempts";
        const string ToFahr = "{0}ºC in Fahrenheit are {1}ºF";
        const string ToCel = "{0}ºF in Celsius are {1}ºC";
        const string ToKelv = "{0}ºC in Kelvin are {1}K";
        int count, tempOp = 0, op = 0-1;
        double temp = 0.0, tempChange;

        do
        {
            try
            {
                op = validateOption(MsgExercise);
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
                        count = 0;
                        temp = validateInput(EnterTemp);
                        validateOptioTemp(TypeConvert, count, ref tempOp);
                        switch (tempOp)
                        {
                            case 1:
                                tempChange = temp * (9.0 / 5.0) + 32;
                                WriteTemp(ToFahr, temp, tempChange);
                                break;
                            case 2:
                                tempChange = (temp - 32.0) * (5.0 / 9.0);
                                WriteTemp(ToCel, temp, tempChange);
                                break;
                            case 3:
                                tempChange = temp + 273.15;
                                WriteTemp(ToKelv, temp, tempChange);
                                break;
                            default:
                                Console.WriteLine(NoAttempts);
                                break;
                        }
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
    public static int validateOption(string text)
    {
        int value;
        do
        {
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
        } while (!Int32.TryParse(Console.ReadLine(), out value));
        Console.ForegroundColor = ConsoleColor.White;
        return value;
    }
    public static double validateInput(string text)
    {
        double value;
        do
        {
            Console.Write(text);
            Console.ForegroundColor= ConsoleColor.Green;
        } while (!Double.TryParse(Console.ReadLine(), out value));
        Console.ForegroundColor = ConsoleColor.White;
        return value;
    }
    public static void validateOptioTemp(string TypeConvert, int count, ref int tempOp)
    {
        do
        {
            tempOp = validateInput(TypeConvert, tempOp, ref count);
        } while (!isInRange(tempOp, 1, 3) && count < 3);
    }
    public static int validateInput(string text, int value, ref int count)
    {
        do
        {
            Console.WriteLine(text);
            count++;
        } while (!Int32.TryParse(Console.ReadLine(), out value) && count < 3);
        return value;
    }
    public static bool isInRange(int value, int min, int max) => value >= min && value <= max;
    public static void WriteTemp(string text, double temp, double tempChange)
    {
        tempChange = Math.Round(tempChange, 2);
        Console.WriteLine(text, temp, tempChange);
    }
}