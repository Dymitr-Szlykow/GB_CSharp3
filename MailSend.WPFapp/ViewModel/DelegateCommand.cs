using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MailSend.WPFapp.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public DelegateCommand(Action<object> execute = null, Func<object, bool> canExecute = null)
        {
            _Execute = execute;
            _CanExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _CanExecute == null || _CanExecute(parameter);
        public void Execute(object parameter) => _Execute(parameter);
    }
}
