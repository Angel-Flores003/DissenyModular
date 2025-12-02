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
        const string MsgHours = "Enter the hours: ";
        const string MsgMinutes = "Enter the minutes: ";
        const string HavePay = "You have to pay {0}€ for the parking.";
        double hours = 0, minutes = 0, price = 0, op = -1;

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
                        hours = validateInput(MsgHours);
                        AbsoluteValue(ref hours);
                        minutes = validateInput(MsgMinutes);
                        AbsoluteValue(ref minutes);
                        price = ParkingCost(hours, ref minutes, price);
                        Console.WriteLine(HavePay, price);
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
    public static double ParkingCost(double h, ref double min, double price)
    {
        AllMinutes(ref h, min);
        if (h <= 1)
        {
            price = 3.50;
        }
        else if (h > 1 && h <= 5)
        {
            price = ((h - 1) * 2.0) + 3.50;
        }
        else
        {
            price = ((h - 6) * 1.50) + 3.50 + 8.0;
        }
        price = Math.Round(price, 2);
        return price;
    }
    public static void AllMinutes(ref double h, double min)
    {
        h += (min / 60.0);
    }
    public static void AbsoluteValue(ref double num)
    {
        if (num < 0)
            num *= -1;
    }

}