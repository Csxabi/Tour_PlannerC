using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CSTourPlanner.M;
using System.Threading.Tasks;

namespace CSTourPlanner.VM
{
    public class EditLogViewModel : INotifyPropertyChanged
    {
        public EditLogViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
