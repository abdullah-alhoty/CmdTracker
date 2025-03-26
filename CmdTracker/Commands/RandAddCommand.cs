namespace CmdTracker.Commands
{
    public class RandAddCommand : ICommand
    {
        private Random _random = new Random();
        public int Execute(int currentValue){
            int randValue = _random.Next(1, 11);
            return currentValue + randValue;
        }
        public int Undo(int currentValue){
            int randValue = _random.Next(1, 11);
            return currentValue - randValue;
        }
    }
}