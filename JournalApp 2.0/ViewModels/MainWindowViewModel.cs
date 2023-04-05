using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JournalApp.ViewModels.Base;
using JournalApp.Infrastructure.Commands;
using System.Windows;

namespace JournalApp.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        private string title = "УП наше крутое";

        /// <summary>Заголовок окна </summary>

        #region Команды

        public ICommand CloseApplicationCommand { get; }

        public bool CanCloseApplicationCommandExicute(object p)
        {
            return true;
        }

        public void OnCloseApplicationCommandExicuted(object p)
        {
            Application.Current.Shutdown();
        }
        
        #endregion

        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExicuted, CanCloseApplicationCommandExicute);
        }
    }
}
