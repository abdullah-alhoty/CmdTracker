using System;
using CmdTracker.Commands;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1 || !int.TryParse(args[0], out int initialValue))
        {
            Console.WriteLine("Bitte einen gültigen Startwert über die Kommandozeile angeben.");
            return;
        }

        CommandProcessor processor = new CommandProcessor(initialValue);
        Console.WriteLine($"Startwert: {initialValue}");
    }
}
