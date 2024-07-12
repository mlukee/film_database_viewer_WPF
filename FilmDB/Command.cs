using System.Windows.Input;

namespace FilmDB
{
    public class Command : ICommand
    {
        public Command(Action<object?> action)
        {
            this.action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true; // If CanExecute returns false, Execute will not be called
        }

        public void Execute(object? parameter)
        {
            if (action != null)
            {
                action(parameter);
            }
            //MessageBox.Show("Command executed");
        }

        private Action<object?> action;
    }
}