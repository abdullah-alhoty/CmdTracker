namespace CmdTracker.Commands
{
    public class RandAddCommand : ICommand
    {
        private int _randValue;
        private Random _random = new Random();
        public int Execute(int currentValue){
            _randValue = _random.Next(1, 11);
            return currentValue + _randValue;
        }
        public int Undo(int currentValue){
            _randValue = _random.Next(1, 11);
            return currentValue - _randValue;
        }
    }
}