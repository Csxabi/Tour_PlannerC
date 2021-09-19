using System;
using System.Windows.Input;

namespace CSTourPlanner.VM
{
    internal class AddLogCom : ICommand
    {
        private TourViewModel _TourViewModel;

        public AddLogCom(TourViewModel mainViewModel)
        {
            _TourViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _TourViewModel.AddLog();
        }
    }
}