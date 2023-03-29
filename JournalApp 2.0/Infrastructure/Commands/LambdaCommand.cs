using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp.Infrastructure.Commands.Base;

namespace JournalApp.Infrastructure.Commands
{
    public class LambdaCommand : Command
    {
        private readonly Action<object> excute;
        private readonly Func<object, bool> canExecute;

        public LambdaCommand(Action <object> Excute, Func <object, bool> CanExecute = null)
        {
            excute = Excute ?? throw new ArgumentNullException(nameof(Execute));
            canExecute = CanExecute;
        } 
        
        public override bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }
        public override void Execute(object parameter)
        {
            excute(parameter);
        }
    }


}
