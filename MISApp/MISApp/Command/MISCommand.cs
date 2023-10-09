using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MISApp.Command
{
    public class MISCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action execute;
        private readonly Func<bool> canExecute;
        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
