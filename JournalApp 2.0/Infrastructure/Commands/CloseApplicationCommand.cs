using JournalApp.Infrastructure.Commands.Base;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Infrastructure.Commands
{
    class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
