namespace CmdTracker.Commands
{
    public class DoubleCommand : ICommand
    {
        public int Execute(int currentValue) => currentValue *2;
        public int Undo(int currentValue) => currentValue / 2;
    }
}