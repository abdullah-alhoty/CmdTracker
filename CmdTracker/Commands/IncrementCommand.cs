namespace CmdTracker.Commands
{
    public class IncrementCommand : ICommand
    {
        public int Execute(int currentValue) => currentValue + 1;
        public int Undo(int currentValue) => currentValue - 1;
    }
}
