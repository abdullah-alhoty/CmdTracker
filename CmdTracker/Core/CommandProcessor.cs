namespace CmdTracker.Commands
{
    public class CommandProcessor
    {
        private int _currentValue;
        private Stack<ICommand> _history = new Stack<ICommand>();

        public CommandProcessor(int initialValue)
        {
            _currentValue = initialValue;
        }

        public void ExecuteCommand(ICommand command)
        {
            _currentValue = command.Execute(_currentValue);
            _history.Push(command);
            Console.WriteLine($"Result: {_currentValue}");
        }

        public void UndoLastCommand()
        {
            if (_history.Count > 0)
            {
                ICommand lastCommand = _history.Pop();
                _currentValue = lastCommand.Undo(_currentValue);
                Console.WriteLine($"Undo executed. Result: {_currentValue}");
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }
    }
}
