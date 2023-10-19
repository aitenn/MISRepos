using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MISApp.Command
{
    public class MyCommand : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public MyCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return this.canExecute.Invoke();
        }

        public void Execute(object? parameter)
        {
            this.execute.Invoke();
        }
    }
}
