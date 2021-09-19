using System;
using System.Windows.Input;

namespace CSTourPlanner.VM
{
    internal class DelLogCom : ICommand
    {
        private TourViewModel _TourViewModel;

        public DelLogCom(TourViewModel mainViewModel)
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
            _TourViewModel.DelLog();
        }
    }
}