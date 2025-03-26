using System;
using CmdTracker.Commands;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bitte Startwert eingeben: ");
        int initialValue;
        while (!int.TryParse(Console.ReadLine(), out initialValue))
        {
            Console.WriteLine("Ungueltige Eingabe. Bitte eine Zahl eingeben.");
            return;
        }

        CommandProcessor processor = new CommandProcessor(initialValue);
        Console.WriteLine($"Startwert: {initialValue}");

        while (true)
        {
            Console.WriteLine("\nVerfügbare Befehle: increment, decrement, double, randadd, undo, exit");
            string? command = Console.ReadLine()?.ToLower();

            switch (command)
            {
                case "increment":
                    processor.ExecuteCommand(new IncrementCommand());
                    break;
                case "decrement":
                    processor.ExecuteCommand(new DecrementCommand());
                    break;
                case "double":
                    processor.ExecuteCommand(new DoubleCommand());
                    break;
                case "randadd":
                    processor.ExecuteCommand(new RandAddCommand());
                    break;
                case "undo":
                    processor.UndoLastCommand();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Unbekannter Befehl.");
                    break;
            }
        }
        
    }
}
